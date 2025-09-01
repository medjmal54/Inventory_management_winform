using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManagement : Form
    {
        DataTable inventory = new DataTable();
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void InvManageLabel_Click(object sender, EventArgs e)
        {

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Short description");
            inventory.Columns.Add("Quantity");

            InventoryGridView.DataSource = inventory;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SKUtextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                NametextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                PricetextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                ShDesctextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                QuantitytextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                CategoryBox.SelectedIndex = CategoryBox.Items.IndexOf(itemToLookFor);

            }
            catch (Exception err)
            {
                Console.WriteLine("error: " + err);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SKUtextBox.Text = "";
            NametextBox.Text = "";
            PricetextBox.Text = "";
            ShDesctextBox.Text = "";
            QuantitytextBox.Text = "";
            CategoryBox.SelectedIndex = -1;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sku = SKUtextBox.Text;
            string name = NametextBox.Text;
            string price = PricetextBox.Text;
            string shortdesc = ShDesctextBox.Text;
            string quantity = QuantitytextBox.Text;
            string category = (string)CategoryBox.SelectedItem;
            if (sku == null || name == null || price == null || quantity == null || category == null)
            {
                MessageBox.Show("Please make sure to fill all required fields");
                return;
            }

            inventory.Rows.Add(sku, name, category, price, shortdesc, quantity);

            NewButton_Click(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error:" + err);
            }
        }

        private void ShDesctextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
