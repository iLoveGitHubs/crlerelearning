using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Robotics
{
    class BindingClass : INotifyPropertyChanged
    {
        //textbox 1
        private int soOToiDaDiDuoc;
        public int SoOToiDaDiDuoc
        {
            get { return soOToiDaDiDuoc; }
            set
            {
                if (value == SoOToiDaDiDuoc) return;
                soOToiDaDiDuoc = value;
                OnPropertyChanged("SoOToiDaDiDuoc");
            }
        }
        //textbox 2
        private float tiLeBaoPhu;
        public float TiLeBaoPhu
        {
            get { return tiLeBaoPhu; }
            set
            {
                if (value == TiLeBaoPhu) return;
                tiLeBaoPhu = value;
                OnPropertyChanged("TiLeBaoPhu");
            }
        }
        //textbox 3
        private int soBuocToiDaSeDi;
        public int SoBuocToiDaSeDi
        {
            get { return soBuocToiDaSeDi; }
            set
            {
                if (value == SoBuocToiDaSeDi) return;
                soBuocToiDaSeDi = value;
                OnPropertyChanged("SoBuocToiDaSeDi");
            }
        }
        //textbox 4
        private int soBuocDaDi;
        public int SoBuocDaDi
        {
            get { return soBuocDaDi; }
            set
            {
                if (value == SoBuocDaDi) return;
                soBuocDaDi = value;
                OnPropertyChanged("SoBuocDaDi");
            }
        }
        //textbox 5
        private int thoiGianGioiHan;
        public int ThoiGianGioiHan
        {
            get { return thoiGianGioiHan; }
            set
            {
                if (value == ThoiGianGioiHan) return;
                thoiGianGioiHan = value;
                OnPropertyChanged("ThoiGianGioiHan");
            }
        }
        //textbox 6
        private int soOChePhuTrongTGiay;
        public int SoOChePhuTrongTGiay
        {
            get { return soOChePhuTrongTGiay; }
            set
            {
                if (value == SoOChePhuTrongTGiay) return;
                soOChePhuTrongTGiay = value;
                OnPropertyChanged("SoOChePhuTrongTGiay");
            }
        }
        //textbox 7
        private int soOLapLai;
        public int SoOLapLai
        {
            get { return soOLapLai; }
            set
            {
                if (value == SoOLapLai) return;
                soOLapLai = value;
                OnPropertyChanged("SoOLapLai");
            }
        }
        //textbox 8
        private float tiLeLapLai;
        public float TiLeLapLai
        {
            get { return tiLeLapLai; }
            set
            {
                if (value == TiLeLapLai) return;
                tiLeLapLai = value;
                OnPropertyChanged("TiLeLapLai");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
