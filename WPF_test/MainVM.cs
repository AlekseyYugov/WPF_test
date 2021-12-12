using System;
using System.Windows.Media.Imaging;
using System.ComponentModel;

namespace WPF_test
{
    public class MainVM : INotifyPropertyChanged
    {
        public BitmapImage bmi_1 = null;
        private BitmapImage bmi_2 = null;
        private BitmapImage bmi_3 = null;
        private int _progress = 0;
        private string _url_1 = null;
        private string _url_2 = null;
        private string _url_3 = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Progress
        {
            get { return _progress; }
            set
            {
                
                _progress = value;
                NotifyPropertyChanged("Progress");
            }
        }
        
        public string Url_1
        {
            get { return _url_1; }
            set
            {
                _url_1 = value;
                NotifyPropertyChanged("Url_1");
            }
        }
        public string Url_2
        {
            get { return _url_2; }
            set
            {
                _url_2 = value;
                NotifyPropertyChanged("Url_2");
            }
        }

        public string Url_3
        {
            get { return _url_3; }
            set
            {
                _url_3 = value;
                NotifyPropertyChanged("Url_3");
            }
        }
        
        public BitmapImage BitmapImg_1
        {
            get { return bmi_1; }
            set { bmi_1 = value; }
        }
        public BitmapImage BitmapImg_2
        {
            get { return bmi_2; }
            set { bmi_2 = value; }
        }
        public BitmapImage BitmapImg_3
        {
            get { return bmi_3; }
            set { bmi_3 = value; }
        }
        

        public MainVM() { }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged!=null)PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        
        public void loadImage_1()
        {

            bmi_1 = new BitmapImage();
            bmi_1.BeginInit();
            if (_url_1 != "" && _url_1 != null)
            {
                try
                {
                    
                    bmi_1.UriSource = new Uri(_url_1);
                    bmi_1.DownloadProgress += new EventHandler<DownloadProgressEventArgs>(bmi_DownloadProgress);
                    bmi_1.EndInit();

                }
                catch (System.UriFormatException)
                {

                    bmi_1.UriSource = null;
                }
                
                

                NotifyPropertyChanged("BitmapImg_1");
                
            }
            

        }
        public void loadImage_2()
        {
            bmi_2 = new BitmapImage();
            bmi_2.BeginInit();
            if (_url_2 != "" && _url_2 != null)
            {
                try
                {
                    bmi_2.UriSource = new Uri(_url_2);
                    bmi_2.DownloadProgress += new EventHandler<DownloadProgressEventArgs>(bmi_DownloadProgress);
                    bmi_2.EndInit();
                }
                catch (System.UriFormatException)
                {

                    bmi_2.UriSource = null;
                }
                
                NotifyPropertyChanged("BitmapImg_2");
            }
            
        }
        public void loadImage_3()
        {
            bmi_3 = new BitmapImage();
            bmi_3.BeginInit();
            if (_url_3 != "" && _url_3 != null)
            {
                try
                {
                    bmi_3.UriSource = new Uri(_url_3);
                    bmi_3.DownloadProgress += new EventHandler<DownloadProgressEventArgs>(bmi_DownloadProgress);
                    bmi_3.EndInit();
                }
                catch (System.UriFormatException)
                {

                    bmi_3.UriSource = null;
                }
                
                NotifyPropertyChanged("BitmapImg_3");
            }
            
        }

        public void bmi_DownloadProgress(object sender, DownloadProgressEventArgs e)
        {
            Progress = e.Progress;

        }
    }
}
