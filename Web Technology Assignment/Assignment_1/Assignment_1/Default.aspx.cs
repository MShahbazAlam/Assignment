using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //dropdown list with items
                ddlItems.Items.Add(new ListItem("Ferrari Monza", "Ferrari Monza.png"));
                ddlItems.Items.Add(new ListItem("Jaguar", "jaguar.png"));
                ddlItems.Items.Add(new ListItem("Lamborghini Huracan STO", "Lamborghini Huracan STO.png"));
                ddlItems.Items.Add(new ListItem("Lotus Evija", "Lotus Evija.png"));
                ddlItems.Items.Add(new ListItem("Maserati MC20", "Maserati MC20.png"));
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //image based on the selected item
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"Image/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            //cost of the selected item 
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        
        private string GetItemCost(string item)
        {
            switch (item)
            {
                case "Ferrari Monza":
                    return "Rs 20000000";
                case "Jaguar":
                    return "Rs 5000000000000";
                case "Lamborghini Huracan STO":
                    return "Rs 100000000000";
                case "Lotus Evija":
                    return "Rs 200000000000";
                case "Maserati MC20":
                    return "Rs 7000000000";
                default:
                    return "";
            }
        }
    }
}