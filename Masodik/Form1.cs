using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Masodik
{
    public partial class Form1 : Form
    {
        List<Beer> sörök;
        Beer selected = null;

        public Form1()
        {
            InitializeComponent();

            getData();
            selected = sörök[0];

            foreach (var sör in sörök)
            {
                cmbBx.Items.Add(sör.name);
            }
        }

        private async Task getData()
        {
            //string url = "https://api.punkapi.com/v2/beers";
            //var client = new HttpClient();
            //string content = await client.GetStringAsync(url); // json string
            //sörök = JsonConvert.DeserializeObject<List<Beer>>(content); // c# osztály


            sörök = new List<Beer>()
            {
                new Beer
                {
                    id = 1,
                    description = "desc 1vdnfkdsjfhnkdjsfhnsdkjaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    ibu = 70,
                    url = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrsesmAmSyIqWAjmo8wMgiF6RktprEZMr7Pj90l9wUrMWTO8Zk7UegE4kgjSSBTITVlwQ&usqp=CAU",
                    name = "sanyi",
                    tagline = "asdsad",
                    ingradients = new ingradience
                    {
                        malt = new List<Malt>
                        {
                            new Malt
                            {
                               name = "malt name",
                               amount = new amount()
                               {
                                   value = 10,
                                   unit = "12"
                               }
                            }
                        }
                    }
                },
                new Beer
                {
                    id = 1,
                    description = "desc",
                    ibu = 30,
                    url = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrsesmAmSyIqWAjmo8wMgiF6RktprEZMr7Pj90l9wUrMWTO8Zk7UegE4kgjSSBTITVlwQ&usqp=CAU",
                    name = "sanyi 2",
                    tagline = "asdsad",
                    ingradients = new ingradience
                    {
                        malt = new List<Malt>
                        {
                            new Malt
                            {
                               name = "malt name",
                               amount = new amount()
                               {
                                   value = 10,
                                   unit = "12"
                               }
                            }
                        }
                    }
                }
            };
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = sörök.FirstOrDefault(sör => sör.name == cmbBx.Text);

            
            if (result is null) return;

            selected = result;

            pctrBx.ImageLocation = selected.url;
            textBox1.Text = selected.description;
            txtBx.Text = selected.tagline;
            prgBr.Value = selected.ibu;

            //var formattedMalt = new List<MaltDisplayModel>();
            //foreach (var malt in selected.ingradients.malt)
            //{
            //    formattedMalt.Add(new MaltDisplayModel
            //    {
            //        name = malt.name,
            //        unit = malt.amount.unit,
            //        value = malt.amount.value
            //    });
            //}

            var masikModszer = selected.ingradients
                .malt.Select(malt => new MaltDisplayModel
                {
                    name = malt.name,
                    unit = malt.amount.unit,
                    value = malt.amount.value
                })
                .ToList();

            //dtGrdVw.DataSource = formattedMalt;
            dtGrdVw.DataSource = masikModszer;

        }
    }
}
