namespace KZkal
{
    public partial class Form1 : Form
    {
        int minTime = 0;
        int maxTime = 0;
        bool isMaxPunishment = false;
        List<int> punishmentTimes = new List<int>();

        private double currentTotalTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void xx1_Click(object sender, EventArgs e)
        {
            minTime = 5;
            maxTime = 10;
            AddPunishmentTime();
            TriggerResultUpdate();
        }

        private void xx2_Click(object sender, EventArgs e)
        {
            minTime = 10;
            maxTime = 15;
            AddPunishmentTime();
            TriggerResultUpdate();
        }

        private void xx3_Click(object sender, EventArgs e)
        {
            minTime = 15;
            maxTime = 25;
            AddPunishmentTime();
            TriggerResultUpdate();
        }

        private void xx4_Click(object sender, EventArgs e)
        {
            minTime = 20;
            maxTime = 35;
            AddPunishmentTime();
            TriggerResultUpdate();
        }

        private void xx5_Click(object sender, EventArgs e)
        {
            minTime = 30;
            maxTime = 50;
            AddPunishmentTime();
            TriggerResultUpdate();
        }

        private void xx6_Click(object sender, EventArgs e)
        {
            Result.Text = "PERMA";
            punishmentTimes.Clear();
        }

        private void KZMax_CheckedChanged(object sender, EventArgs e)
        {
            isMaxPunishment = KZMax.Checked;
            TriggerResultUpdate();
        }

        private void AddPunishmentTime()
        {
            punishmentTimes.Add(isMaxPunishment ? maxTime : minTime);
        }

        private void TriggerResultUpdate()
        {
            if (Result.Text == "PERMA")
                return;

            if (punishmentTimes.Count == 0)
            {
                Result.Text = " ";
                return;
            }

            double totalMinutes = punishmentTimes.Sum(x => (double)x);
            double maxAllowedTime = punishmentTimes.Max() * 1.5;

            if (totalMinutes > maxAllowedTime)
            {
                totalMinutes = maxAllowedTime;
            }

            int fullMinutes = (int)totalMinutes;
            double fractionalMinutes = totalMinutes - fullMinutes;

            int seconds = (int)(fractionalMinutes * 60);

            string formattedTime = string.Format("{0:D2}:{1:D2}", fullMinutes, seconds);
            Result.Text = formattedTime;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
        }

        private double currentTime = 0;

        private void Relapse_Click(object sender, EventArgs e)
        {
            if (Result.Text == "PERMA" || punishmentTimes.Count == 0)
                return;

            double totalMinutes = punishmentTimes.Sum(x => (double)x);
            double maxAllowedTime = punishmentTimes.Max() * 1.5;

            if (totalMinutes > maxAllowedTime)
            {
                totalMinutes = maxAllowedTime;
            }

            if (currentTime == 0)
            {
                currentTime = totalMinutes;
            }

            currentTime *= 1.15;

            int fullMinutes = (int)currentTime;
            double fractionalMinutes = currentTime - fullMinutes;

            int seconds = (int)(fractionalMinutes * 60);

            string formattedTime = string.Format("{0:D2}:{1:D2}", fullMinutes, seconds);
            Result.Text = formattedTime;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            punishmentTimes.Clear();
            Result.Text = string.Empty;
            KZMax.Checked = false;
            minTime = 0;
            maxTime = 0;
        }

        private void ModifyTotalTime(double percent)
        {
            if (Result.Text == "PERMA")
                return;

            double totalMinutes = punishmentTimes.Sum(x => (double)x);
            if (totalMinutes == 0)
                return;

            double modification = totalMinutes * (percent / 100);
            totalMinutes += modification;

            double maxAllowedTime = punishmentTimes.Max() * 1.5;
            if (totalMinutes > maxAllowedTime)
            {
                totalMinutes = maxAllowedTime;
            }

            int fullMinutes = (int)totalMinutes;
            double fractionalMinutes = totalMinutes - fullMinutes;

            int seconds = (int)(fractionalMinutes * 60);

            string formattedTime = string.Format("{0:D2}:{1:D2}", fullMinutes, seconds);
            Result.Text = formattedTime;
        }

        private void Add5_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(5);
        }

        private void Add10_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(10);
        }

        private void Add15_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(15);
        }

        private void Add20_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(20);
        }

        private void Rem50_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-50);
        }

        private void Rem45_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-45);
        }

        private void Rem40_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-40);
        }

        private void Rem35_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-35);
        }

        private void Rem30_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-30);
        }

        private void Rem25_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-25);
        }

        private void Rem20_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-20);
        }

        private void Rem15_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-15);
        }

        private void Rem10_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-10);
        }

        private void Rem5_Click(object sender, EventArgs e)
        {
            ModifyTotalTime(-5);
        }
        private void circ_Click(object sender, EventArgs e)
        {
        }

        private void QL_Click(object sender, EventArgs e)
        {

        }

        private void MadeBy_Click(object sender, EventArgs e)
        {
            // Kinar_7
        }
    }
}
