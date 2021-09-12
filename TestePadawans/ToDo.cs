using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;

namespace TestePadawans
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = apiClient.GetAsync(requestUri: "todos").Result;
            var todo = response.Content.ReadAsAsync<IEnumerable<ToDos>>().Result;
            dataGridView1.DataSource = todo;
        }
    }
}
