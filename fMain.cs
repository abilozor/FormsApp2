using System;
using System.Windows.Forms;

namespace lab_work_4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCars.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ModelName";
            column.Name = "Модель";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Manufacturer";
            column.Name = "Виробник";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfProduction";
            column.Name = "Рік випуску";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "EngineCapacity";
            column.Name = "Об'єм двигуна (л)";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SeatCount";
            column.Name = "Кількість місць";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "IsElectric";
            column.Name = "Електричний";
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "AverageFuelConsumption";
            column.Name = "Середня витрата палива (л/100км)";
            gvCars.Columns.Add(column);

            bindSrcCars.Add(new Car("Tesla Model S", "Tesla", 2022, 0, 5, true, 0));
            EventArgs args = new EventArgs(); OnResize(args);
        }
        private void fMain_Resize(object sender, EventArgs e) 
        {
            int buttonSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnEdit.Margin = new Padding(Width - buttonSize, 0, 0, 0);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();

            fCar fc = new fCar(car);
            if(fc.ShowDialog() == DialogResult.OK) 
            {
                bindSrcCars.Add(car);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Car car = (Car)bindSrcCars.List[bindSrcCars.Position];

            fCar fc = new fCar(ref car);
            if(fc.ShowDialog() == DialogResult.OK)
            {
                bindSrcCars.List[bindSrcCars.Position] = car;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Видалити поточний запис?", "Видалення запису", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcCars.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            {
                bindSrcCars.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Закрити застосунок?", "Вихід з програми", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK ) 
            {
                Application.Exit();
            }
        }
    }
}
