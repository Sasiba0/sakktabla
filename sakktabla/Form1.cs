namespace sakktabla
{
    public partial class Form1 : Form
    {
        const int meret = 30;
        List<int> kezdotabla = new List<int> 
        {
            0,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,0
        };
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tile t = new tile(i,j);
                    t.Left = i * meret;
                    t.Top = j * meret;
                    t.Width = meret;
                    t.Height = meret;
                    t.BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(t);
                }
            }

            foreach (tile t in Controls)
            {
                if ((t.j == 0 || t.i == 0) && t.i+t.j > 0)
                {
                    t.BackColor = Color.LightPink;
                    t.Click += T_Click;
                }

                if (t.j + t.i == 0)
                {
                    t.BackColor = Color.Gray;
                }

                
            }

            for (int i = 0;i < kezdotabla.Count;i++) 
            {
                int ii = i / 8;
                int ij = i % 8;
                bool ifeher = Convert.ToBoolean(kezdotabla[i]);
                foreach (tile t in Controls)
                {
                    if (t.i == ii+1 && t.j == ij+1)
                    {
                        t.feher = ifeher;
                        if (ifeher)
                        {
                            t.BackColor = Color.White;
                        }

                        else 
                        {
                            t.BackColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void T_Click(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            tile ti = (tile)sender;
            if (ti.i == 0)
            {
                foreach (tile t in Controls)
                {
                    if (t.j == ti.j && t.i>0)
                    {
                        Szinvaltoztat(t);
                    }
                }
            }

            else
            {
                foreach (tile t in Controls)
                {
                    if (t.i == ti.i && t.j > 0)
                    {
                        Szinvaltoztat(t);
                    }
                }
            }
        }

        void Szinvaltoztat(tile t)
        {
            if(t.feher)
            {
                t.BackColor = Color.Black;
            }

            else
            {
                t.BackColor = Color.White;
            }
            t.feher = !t.feher;
        }
    }
}
