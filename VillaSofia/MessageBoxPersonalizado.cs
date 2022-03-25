using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace VillaSofia
{
    public partial class MessageBoxPersonalizado : Form
    {
        public MessageBoxPersonalizado()
        {
            InitializeComponent();
        }

        private static System.Timers.Timer aTimer;


        private void MessageBoxPersonalizado_Load(object sender, EventArgs e)
        {
            SetTimer();

            
        }

        void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(3000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Dispose();
        }

    }
}
