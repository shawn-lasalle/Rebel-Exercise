using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rebel_Exercise
{
    public partial class Home : System.Web.UI.Page
    {
        protected List<NameValuePair> AddedItems
        {
            get
            {
                if (!(ViewState["PairsList"] is List<NameValuePair>))
                {
                    ViewState["PairsList"] = new List<NameValuePair>();
                }

                return (List<NameValuePair>)ViewState["PairsList"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            AddedItemsList.DataSource = AddedItems;
            AddedItemsList.DataValueField = "Key";
            AddedItemsList.DataTextField = "DisplayValue";
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] pairToAdd = AddItemTextBox.Text.Split('=');
            AddedItems.Add(new NameValuePair(pairToAdd[0], pairToAdd[1]));
            AddItemTextBox.Text = "";
            UpdateBindings();
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            AddedItems.Remove(AddedItems.Find(x => x.Key == AddedItemsList.SelectedValue));
            UpdateBindings();
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            AddedItems.Clear();
            UpdateBindings();
        }

        protected void ExportButton_Click(object sender, EventArgs e)
        {
            XmlDocument exportFile = new XmlDocument();

            XmlNode declaration = exportFile.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            exportFile.AppendChild(declaration);

            XmlElement root = exportFile.CreateElement("Root");
            exportFile.AppendChild(root);

            foreach (NameValuePair pair in AddedItems)
            {
                XmlElement element = exportFile.CreateElement("NameValuePair");
                element.SetAttribute("Value", pair.Value);
                element.SetAttribute("Key", pair.Key);
                root.AppendChild(element);
            }

            exportFile.Save(Server.MapPath("~") + @"\ExportFile.xml");
            string strContents = null;
            System.IO.StreamReader objReader = default(System.IO.StreamReader);
            objReader = new System.IO.StreamReader(Server.MapPath("~") + @"\ExportFile.xml");
            strContents = objReader.ReadToEnd();
            objReader.Close();

            string attachment = "attachment; filename=ExportFile.xml";
            Response.ClearContent();
            Response.ContentType = "application/xml";
            Response.AddHeader("content-disposition", attachment);
            Response.Write(strContents);
            Response.End();
            File.Delete(Server.MapPath("~") + @"\ExportFile.xml");
        }

        protected void SortNameButton_Click(object sender, EventArgs e)
        {
            AddedItems.Sort((x, y) => string.Compare(x.Key, y.Key));
            UpdateBindings();
        }

        protected void SortValueButton_Click(object sender, EventArgs e)
        {
            AddedItems.Sort((x, y) => string.Compare(x.Value, y.Value));
            UpdateBindings();
        }

        protected void UpdateBindings()
        {
                AddedItemsList.DataBind();
        }
    }
}