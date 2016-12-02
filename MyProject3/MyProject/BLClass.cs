using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject;

namespace MyProject
{
    class BLClassAdmin
    {
        
           
            
         public WherePainted AddWP (Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe,string cou)
            {
                WherePainted port = new WherePainted();
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.People = Pe;
                port.Country = cou;
                return port;
            }
            public FamousPeople AddFP(Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe,bool cou)
            {
                FamousPeople port = new FamousPeople();
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.People = Pe;
                port.Famous = cou;
                return port;
            }
            public Landscape AddLandscape (Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Vi)
            {
                Landscape port = new Landscape();
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.View = Vi;
                return port;
            }
        public WherePainted Change(WherePainted port, Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, string cou)
        {

            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.People = Pe;
            port.Country = cou;
            return port;
        }
        public FamousPeople ChangeFP(FamousPeople port,Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, bool cou)
        {
  
            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.People = Pe;
            port.Famous = cou;
            return port;
        }
        public Landscape ChangeLandscape(Landscape port,Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Vi)
        {
            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.View = Vi;
            return port;
        }

    }
}
