using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class browstart : Form
    {
        private int kolPages = 0;//для наследования
        List<string> history = new List<string>();
    
        public browstart()
        {
            InitializeComponent();

            

        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
           
        }
        

        private void goSearch_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            if (!String.IsNullOrEmpty(search.Text))
            {
                webBrowser.Navigate(search.Text);
                listHistory.Items.Add(search.Text);//на выбранной вкладке контролс нулевой  метод навигейт в качетсве содержимово принимает на вход
            }
           
        }

        private void browstart_Load(object sender, EventArgs e)
        {

            WebBrowser browser = new WebBrowser();
            
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;//чтобы высвечивалась название сайта
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(kolPages);
            tabControl1.SelectedTab.Controls.Add(browser);
            kolPages++;
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = null;

        }
       

        private void addTab_Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;//чтобы высвечивалась название сайта
            tabControl1.TabPages.Add("новая");
            tabControl1.SelectTab(kolPages);
            tabControl1.SelectedTab.Controls.Add(browser);
            kolPages++;
            
        }

        private void goBack_Click(object sender, EventArgs e)
        {

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
            
        }

        private void goForward_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void goReload_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void deleteTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                kolPages -= 1;
                
            }
            else
            {
                Application.Exit();
            }

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(search.Text);
                listHistory.Items.Add(search.Text);
            }
        }

        private void navigationHandler(object sender, WebBrowserNavigatedEventArgs e)
        {
            history.Add(e.Url.AbsoluteUri);
            listFavorites.Items.Add(e.Url.AbsoluteUri);

        }

        private void addFavorites_Click(object sender, EventArgs e)
        {
            
            listFavorites.Items.Add(search.Text);
        }

        private void finishLoading_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Stop();
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) => listFavorites.Items.RemoveAt(listFavorites.SelectedIndex);
    }
}
    

