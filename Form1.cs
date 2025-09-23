using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysBinding;

namespace BackgroundKeyboard {
    public partial class Form1 : Form {

        private KeyGridBinding binding;
        public Form1() {
            InitializeComponent();
            binding = new KeyGridBinding(dataGridView1);
            binding.startListen();
            this.FormClosed += (s, e) => {
                binding.stopListen();
            };
            bind();
            binding.initGridData();
        }

        void bind() {
            binding.bind("666", () => {
                MessageBox.Show("666");
            },Keys.Alt,Keys.NumPad6);

            binding.bind("777", () => {
                MessageBox.Show("777");
            }, Keys.Alt, Keys.NumPad7);
        }
    }
}
