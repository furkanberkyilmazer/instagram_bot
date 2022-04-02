using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace instabot
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       
        IWebDriver driver = null;


        string kAd;
        IReadOnlyCollection<IWebElement> takipedilenler;
        IReadOnlyCollection<IWebElement> takipciler;
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            groupBox1.Enabled = false;
            this.Text = "�nstagram Bot";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com");
            progressBar1.Visible = false;
            groupBox3.Enabled = false;
            btnCik.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            kAd = txtKullaniciAdi.Text;
            string pass = txtParola.Text;
            driver.FindElement(By.XPath("//*[@id='loginForm']/div/div[1]/div/label/input")).SendKeys(kAd);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div/div[2]/div/label/input")).SendKeys(pass);
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='loginForm']/div/div[3]/button")).Click();
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            checkBox1.Enabled = true;
        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            string gKod = txtGuvenlikKodu.Text;
            driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/div/div[1]/div/form/div[1]/div/label/input")).SendKeys(gKod);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/div/div[1]/div/form/div[2]/button")).Click();
            groupBox3.Enabled = false;
            checkBox1.Enabled = false;




        }


        public void btnTakipGor_Click(object sender, EventArgs e)
        {
            lblSecilen.Text = "";
            btnCik.Visible = false;
            groupBox3.Enabled = false;
            checkBox1.Enabled = false;
            lbTakipci.Items.Clear();
            lblTakipci.Text = "";

            try
            {
                driver.Url = "https://www.instagram.com/" + kAd;

                Thread.Sleep(1000);
                lblTakipci.Text = "L�tfen bekleyiniz...";
                this.Text += " - ��lem Yap�l�yor. L�tfen Bekleyiniz...";
                this.Enabled = false;
                
                try
                {
                    driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a")).Click();
                }
                catch (Exception)
                {
                    driver.FindElement(By.XPath("//*[@id='react-root']/div/div/section/main/div/header/section/ul/li[2]/a")).Click();
                }
                
                Thread.Sleep(2000);


                //scroll kayd�rma

                string jsCommand = "" +
                    "sayfa = document.querySelector('.isgrP');" +
                    "sayfa.scrollTo(0,sayfa.scrollHeight);" +
                    "var sayfaSonu = sayfa.scrollHeight;" +
                    "return sayfaSonu;";

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));

                int sayac = 5;
                while (true)
                {
                    var son = sayfaSonu;
                    Thread.Sleep(800);
                    sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                    if (son == sayfaSonu)
                    {
                        sayac--;
                        if (sayac <= 0)
                        {
                            break;
                        }

                    }


                }
                Thread.Sleep(1000);


                //kayd�rma end


                takipciler = driver.FindElements(By.CssSelector(".notranslate._0imsa"));
                lblTakipci.Text = takipciler.Count().ToString();
                foreach (IWebElement takipci in takipciler)
                {

                    lbTakipci.Items.Add(takipci.Text);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("�stenmeyen bir hata olu�tu...");
                this.Close();
            }
            this.Enabled = true;
            this.Text = "�nstagram Bot";
        }

        public void btnTakipEdilen_Click(object sender, EventArgs e)
        {
            lblSecilen.Text = "";
            btnCik.Visible = false;
            groupBox3.Enabled = false;
            checkBox1.Enabled = false;
            lbTakip.Items.Clear();
            lblTakip.Text = "";

            try
            {

                driver.Url = "https://www.instagram.com/" + kAd;
                Thread.Sleep(1000);
                lblTakip.Text = "L�tfen bekleyiniz...";
                this.Text += " - ��lem Yap�l�yor. L�tfen Bekleyiniz...";
                this.Enabled = false;
                try
                {
                    driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/header/section/ul/li[3]/a")).Click();
                }
                catch (Exception)
                {
                    driver.FindElement(By.XPath("//*[@id='react-root']/div/div/section/main/div/header/section/ul/li[3]/a")).Click();
                    //*[@id="react-root"]/div/div/section/main/div/header/section/ul/li[3]/a   yeni bir hesap ve tam de�ilse bu
                }

                Thread.Sleep(2000);

                //scroll kayd�rma
                string jsCommand = "" +
                        "sayfa = document.querySelector('.isgrP');" +
                        "sayfa.scrollTo(0,sayfa.scrollHeight);" +
                        "var sayfaSonu = sayfa.scrollHeight;" +
                        "return sayfaSonu;";

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                int sayac = 5;
                while (true)
                {
                    var son = sayfaSonu;
                    Thread.Sleep(800);
                    sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                    if (son == sayfaSonu)
                    {
                        sayac--;
                        if (sayac <= 0)
                        {
                            break;
                        }
                    }


                }
                Thread.Sleep(1000);
                //kayd�rma end

                takipedilenler = driver.FindElements(By.CssSelector(".notranslate._0imsa"));
                lblTakip.Text = takipedilenler.Count().ToString();
                foreach (IWebElement takip in takipedilenler)
                {

                    lbTakip.Items.Add(takip.Text);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("�stenmeyen bir hata olu�tu...");
                this.Close();
            }
            this.Enabled = true;
            this.Text = "�nstagram Bot";

        }

        public void btnYakala_Click(object sender, EventArgs e)
        {
            try
            {
                lblSecilen.Text = "";
                btnCik.Visible = false;
                this.Enabled = false;
                int kontrol;
                
                lbYakala.Items.Clear();
                lblYakala.Text = "";
                
                progressBar1.Maximum = int.Parse(lblTakip.Text);
                this.Text += " - ��lem Yap�l�yor. L�tfen Bekleyiniz...";
                progressBar1.Visible = true;
                int i;
                for (i = 0; i < int.Parse(lblTakip.Text); i++)
                {

                    progressBar1.Value = i;
                    kontrol = 0;
                    for (int j = 0; j < int.Parse(lblTakipci.Text); j++)
                    {
                        lbTakip.SelectedIndex = i;
                        lbTakipci.SelectedIndex = j;
                        if (lbTakip.SelectedItem.ToString() == lbTakipci.SelectedItem.ToString())
                        {
                            kontrol++;

                            break;

                        }

                    }
                    if (kontrol == 0)
                    {
                        lbYakala.Items.Add(lbTakip.SelectedItem.ToString());
                    }
                }
                progressBar1.Value = i;
                Thread.Sleep(2000);
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                lblYakala.Text = lbYakala.Items.Count.ToString();
                this.Text = "�nstagram Bot";
                this.Enabled = true;
            }
            catch (Exception)
            {
                progressBar1.Visible = false;
                if (lblTakipci.Text=="")
                {
                    btnTakipGor_Click(btnTakipGor, new EventArgs());
                }
                if (lblTakip.Text=="")
                {
                    btnTakipEdilen_Click(btnTakipEdilen, new EventArgs());
                }
               
                btnYakala_Click(btnYakala, new EventArgs());
            }
            


        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
            
        }

        private void lbYakala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbYakala.SelectedIndex==-1)
            {
                lblSecilen.Text = "";
                btnCik.Visible= false;
            }
            else
            {
                lblSecilen.Text= lbYakala.SelectedItem.ToString();
                for (int i = 0; i < lbTakip.Items.Count; i++)
                {
                    lbTakip.SelectedIndex = i;
                    if (lbTakip.SelectedItem.ToString()==lblSecilen.Text)
                    {
                        break;
                    }
                }
                btnCik.Visible = true;
            }
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            int takipEtmeyenSayisi = int.Parse(lblYakala.Text);
            try
            {
                
                this.Enabled = false;
                this.Text += " - ��lem Yap�l�yor. L�tfen Bekleyiniz...";
                lblYakala.Text = "L�tfen bekleyiniz...";
                driver.Url = "https://www.instagram.com/" + lblSecilen.Text; 
                Thread.Sleep(1000);
                try
                {
                    driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/header/section/div[1]/div[1]/div/div[2]/div/span/span[1]/button")).Click(); //Tam hesaplarda normal hesaplar� takipten ��kma
                   
                }
                catch (Exception)
                {
                    try
                    {
                        driver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/header/section/div[1]/div[2]/div/div[2]/div/span/span[1]/button")).Click(); //tam hesaplarda mavi tikli hesaplar� takipten ��kma
                    }
                    catch (Exception)
                    {
                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/section/main/div/header/section/div[1]/div[1]/div/div[2]/div/span/span[1]/button")).Click(); //Tam olmayan hesaplarda normal hesaplar� takipten ��kma
                        }
                        catch (Exception)
                        {
                            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/section/main/div/header/section/div[1]/div[2]/div/div[2]/div/span/span[1]/button")).Click();  //tam olmayan hesaplarda mavi tikli hesaplar� takipten ��kma

                        }
                        

                    }
                   
                }

                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/ html / body / div[6] / div / div / div / div[3] / button[1]")).Click();
                Thread.Sleep(2000);



                lbYakala.Items.Remove(lbYakala.SelectedItem);
                lbTakip.Items.Remove(lbTakip.SelectedItem);
                lblTakip.Text = (int.Parse(lblTakip.Text) - 1).ToString();

                takipEtmeyenSayisi--;
                lblYakala.Text = takipEtmeyenSayisi.ToString();
                this.Text = "�nstagram Bot";
                this.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("�stenmeyen bir hata olu�tu...");
                this.Close();
            }
            //*[@id="react-root"]/section/main/div/header/section/div[1]/div[2]/div/div[2]/div/span/span[1]/button   mavi tikli hesaplar i�in
            //*[@id="react-root"]/section/main/div/header/section/div[1]/div[1]/div/div[2]/div/span/span[1]/button   normal hesaplar i�in
            
            /* / html / body / div[6] / div / div / div / div[3] / button[1]*/
        }
    }
}