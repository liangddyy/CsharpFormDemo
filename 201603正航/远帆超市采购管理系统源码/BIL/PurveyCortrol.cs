using System;
using System.Collections.Generic;
using System.Text;
using model;
using SQLServerDAL;
using IDAL;
using Model;

namespace BIL
{
    public  class PurveyCortrol
    {
        private static IPurvey p = Factory.getPurvey();
        public static List<PurveyData> ls = PurveyCortrol.getPType();

        public static List<PurveyData> getPType()
        {
            return p.selPurvey();
        }

        public static int addPurevey(PurveyData pd)
        {
            int i = p.insertPurvey(pd);
            pd.ID = i;
            ls.Add(pd);
            return i;
        }

        public static void delPurevey(PurveyData pd)
        {
            p.delPurvey(pd);
            for (int i = 0; i < ls.Count; i++)
            {
                if (pd.ID == ls[i].ID)
                {
                    ls.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
