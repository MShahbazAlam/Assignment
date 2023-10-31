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
                //Dropdown list with Car name
                Items.Items.Add(new ListItem("Select Car", ""));
                Items.Items.Add(new ListItem("Ferrari Monza", "Ferrari Monza.png"));
                Items.Items.Add(new ListItem("Jaguar", "jaguar.png"));
                Items.Items.Add(new ListItem("Lamborghini Huracan STO", "Lamborghini Huracan STO.png"));
                Items.Items.Add(new ListItem("Lotus Evija", "Lotus Evija.png"));
                Items.Items.Add(new ListItem("Maserati MC20", "Maserati MC20.png"));
            }
        }
        protected void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Image URL of the selected Car
            string selectedImageUrl = Items.SelectedItem.Value;
            imgItem.ImageUrl = $"Image/{selectedImageUrl}";

            //Cost of the selected Car
            string selectedItem = Items.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            //Cost Of Car
            Cost.Text = $"Cost of {selectedItem}: {cost}";
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