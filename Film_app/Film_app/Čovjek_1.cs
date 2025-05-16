using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_app
{
    public partial class Čovjek_1 : Form
    {
        Čovjek čovjek = new Čovjek();
        public Čovjek_1()
        {
            InitializeComponent();
        }

        private void Stvori_objekt()
        {
            čovjek.Ime_i_prezime = Ime_text.Text;
            čovjek.Rod = Rod_text.Text;
            čovjek.Godina_rođenja = Int32.Parse(Godina_rođenja_text.Text);
            čovjek.Država_rođenja = Država_rođenja_text.Text;
        }

        private void Očisti()
        {
            Čovjek_ID_text.Text = "";
            Ime_text.Text = "";
            Rod_text.Text = "";
            Godina_rođenja_text.Text = "";
            Država_rođenja_text.Text = "";
        }

        private void Popuni_tablicu()
        {
            using (LjudiEntities1 čovjek_a = new LjudiEntities1())
            { 
                Tablica.DataSource = čovjek_a.Čovjek.ToList<Čovjek>();
            }
        }
        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                Stvori_objekt();

                using (LjudiEntities1 čovjek_a = new LjudiEntities1())
                {
                    čovjek_a.Čovjek.Add(čovjek);
                    čovjek_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Ažuriraj_button_Click(object sender, EventArgs e)
        {
            try
            {
                čovjek.Čovjek_ID = Int32.Parse(Čovjek_ID_text.Text);
                Stvori_objekt();
                using (LjudiEntities1 čovjek_a = new LjudiEntities1())
                {
                    čovjek_a.Entry(čovjek).State = EntityState.Modified;
                    čovjek_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Izbriši_button_Click(object sender, EventArgs e)
        {
            try
            {
                čovjek.Čovjek_ID = Int32.Parse(Čovjek_ID_text.Text);
                Stvori_objekt();
                using (LjudiEntities1 čovjek_a = new LjudiEntities1())
                {
                    čovjek_a.Čovjek.Attach(čovjek);
                    čovjek_a.Čovjek.Remove(čovjek);
                    čovjek_a.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                Popuni_tablicu();
                Očisti();
            }
        }

        private void Čovjek_1_Load(object sender, EventArgs e)
        {
            Popuni_tablicu();
            Očisti();
        }

        private void Čovjek_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Tablica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int redak = e.RowIndex;
            Čovjek_ID_text.Text = Tablica.Rows[redak].Cells[0].Value.ToString();
            Ime_text.Text = Tablica.Rows[redak].Cells[1].Value.ToString();
            Rod_text.Text = Tablica.Rows[redak].Cells[2].Value.ToString();
            Godina_rođenja_text.Text = Tablica.Rows[redak].Cells[3].Value.ToString();
            Država_rođenja_text.Text = Tablica.Rows[redak].Cells[4].Value.ToString();
        }
        private void Film_button_Click(object sender, EventArgs e)
        {
            Filmovi form = new Filmovi();
            form.Show();
            this.Hide();
        }

        private void Strani_button_Click(object sender, EventArgs e)
        {
            Strani form = new Strani();
            form.Show();
            this.Hide();
        }

        private void Hrvatski_button_Click(object sender, EventArgs e)
        {
            Hrvatski form = new Hrvatski();
            form.Show();
            this.Hide();
        }

        private void Nagrade_button_Click(object sender, EventArgs e)
        {
            Nagrade form = new Nagrade();
            form.Show();
            this.Hide();
        }

        private void Film_čovjek_button_Click(object sender, EventArgs e)
        {
            Čovjek_film form = new Čovjek_film();
            form.Show();
            this.Hide();
        }

        private void Produkcijska_kuća_button_Click(object sender, EventArgs e)
        {
            ProdKuća form = new ProdKuća();
            form.Show();
            this.Hide();
        }

        private void Produkcijska_kuća_film_button_Click(object sender, EventArgs e)
        {
            ProdFilm form = new ProdFilm();
            form.Show();
            this.Hide();
        }
    }
}
