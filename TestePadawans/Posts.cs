using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;

namespace TestePadawans
{
    public partial class Posts : Form
    {
        public Posts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = apiClient.GetAsync(requestUri: "posts").Result;
            var post = response.Content.ReadAsAsync<IEnumerable<Postagens>>().Result;
            dataGridView1.DataSource = post;
        }
    }
}
