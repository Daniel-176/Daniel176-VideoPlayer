using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using AxWMPLib;
using System.IO;

namespace VideoApiTest_DEV
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> videoUrls; // Declaração do dicionário
        public Form1()
        {
            InitializeComponent(); 
            videoUrls = new Dictionary<string, string>();
        }

        public class Result
        {
            public string Name { get; set; }
            // Add other properties as needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listITEMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listITEMS.SelectedItem != null && listITEMS.SelectedItem is string) // Verifica se há um item selecionado e se é uma string
            {
                string selectedVideo = listITEMS.SelectedItem.ToString();

                if (videoUrls.ContainsKey(selectedVideo)) // Verifica se o vídeo está presente no dicionário
                {
                    string videoUrl = videoUrls[selectedVideo]; // Obtém a URL com base no nome do vídeo selecionado no dicionário

                    // Manipula o vídeo selecionado
                    PlayVideo(videoUrl, selectedVideo);
                }
            }
        }


        private async void loadVideosList(string type)
        {
            string apiUrl = "https://daniel176.ml/api.php?type=" + type;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    List<string> videoUrlsList = JsonConvert.DeserializeObject<List<string>>(json);

                    videoUrls = new Dictionary<string, string>(); // Criação do dicionário
                    listITEMS.Items.Clear(); // Limpa a ListBox antes de adicionar novos itens
                    foreach (string url in videoUrlsList)
                    {
                        string filename = Path.GetFileName(url);
                        listITEMS.Items.Add(filename);
                        videoUrls.Add(filename, url); // Adiciona a URL ao dicionário com o nome do vídeo como chave
                    }
                }
                catch (Exception ex)
                {
                    textofrandomthingy.Text = ex.Message;
                }
            }
        }



        private void PlayVideo(string videoUrl, string videoName)
        {
            // Implement your video playback logic here
            // For example, you can use a media player control or open the video in a separate player application
            string filename = Path.GetFileName(videoName);
            player.URL = videoUrl;
            videotitle.Text = filename;
            textofrandomthingy.Text = "Loading: "+videoUrl;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedIndex != -1) // Check if an item is selected
            {
                string typea = type.SelectedItem.ToString();
                loadVideosList(typea);
            }
        }
    }
}
