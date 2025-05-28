namespace Practice_04_OOP
{
    public partial class CountryMedal : Form
    {
        string country;
        int sportsmans;
        int count_gold_medals;
        int count_silver_medals;
        int count_bronze_medals;
        public CountryMedal()
        {
            InitializeComponent();
        }
        public void Country(string country, int sportsmans, int gold, int silver, int bronze)
        {
            this.country = country;
            this.sportsmans = sportsmans;
            this.count_gold_medals = gold;
            this.count_silver_medals = silver;
            this.count_bronze_medals = bronze;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(tb_Country.Text)
                || string.IsNullOrEmpty(tb_CountSportsmans.Text)
                || string.IsNullOrEmpty(tb_CountGoldMedals.Text)
                || string.IsNullOrEmpty(tb_CountSilverMedal.Text)
                || string.IsNullOrEmpty(tb_CountBronzeMedal.Text)
                )
            { MessageBox.Show("Недостатьно даних!"); }
            else
            {
                Country(tb_Country.Text,
               Convert.ToInt32(tb_CountSportsmans.Text),
               Convert.ToInt32(tb_CountGoldMedals.Text),
               Convert.ToInt32(tb_CountSilverMedal.Text),
               Convert.ToInt32(tb_CountBronzeMedal.Text)
               );

                tb_Result.Text = tb_Result.Text + $"\r\n" +
                    $"{this.country}:" +
                    $"\r\n\tКількість спортсменів - {this.sportsmans};" +
                    $"\r\n\tкількість золотих медалей - {this.count_gold_medals};" +
                    $"\r\n\tКількість срібних медалей - {this.count_silver_medals};" +
                    $"\r\n\tКількість бронзових медалей - {this.count_bronze_medals}";
            }

               

        }
    }
}
