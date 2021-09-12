using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;

namespace TestePadawans
{
    public partial class Albums : Form
    {
        public Albums()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = apiClient.GetAsync(requestUri: "albums").Result;
            var album = response.Content.ReadAsAsync<IEnumerable<Albuns>>().Result;
            dataGridView1.DataSource = album;
        }
    }
}
