using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.businesslogic;
using umbraco.cms.businesslogic.web;
using umbraco.BusinessLogic;
using umbraco.cms.presentation.Trees;
using umbraco.BusinessLogic.Actions;
using Umbraco.Core;
using Umbraco.Core.Logging;
using umbraco.cms.businesslogic;

namespace uNews
{
    //this class is for v4
    public class uNewsEvents : ApplicationStartupHandler
    {

        private List<string> CreateDocTypes = new List<string>();
        private List<string> RemoveCreateDocTypes = new List<string>();

        public uNewsEvents()
        {
            BaseTree.BeforeNodeRender += new BaseTree.BeforeNodeRenderEventHandler(this.BaseTree_BeforeNodeRender);
            CreateDocTypes.AddRange(System.Web.Configuration.WebConfigurationManager.AppSettings["uNews:CreateDocTypes"].Split(','));
            RemoveCreateDocTypes.AddRange(System.Web.Configuration.WebConfigurationManager.AppSettings["uNews:RemoveCreateDocTypes"].Split(','));
        }

        private void BaseTree_BeforeNodeRender(ref XmlTree sender, ref XmlTreeNode node, EventArgs e)
        {
            if (node.TreeType.ToLower() == "content")
            {
                try
                {
                    Document document = new Document(Convert.ToInt32(node.NodeID));

                    //this changes the create action b/c of the UI.xml entry
                    if (CreateDocTypes.Contains(document.ContentType.Alias))
                    {
                        node.NodeType = "uNews";
                    }

                    if (RemoveCreateDocTypes.Contains(document.ContentType.Alias))
                    {
                        node.Menu.Remove(ActionNew.Instance);
                    }
                }

                catch (Exception e2)
                {

                }                
            }
        }
    }
}
