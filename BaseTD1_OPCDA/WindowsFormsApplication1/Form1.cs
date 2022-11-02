using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;
using System.Collections;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class heat_exchanger_scada : Form
    {
        OPCServer MonServeur;
        OPCGroups MonGrs;
        OPCGroup MonGr_Bool, MonGr_Float;
        OPCItems MonItems_Bool, MonItems_Float;
        OPCItem MonItem;

        public heat_exchanger_scada()
        {
            InitializeComponent();
            MonServeur = new OPCServer();
            MonServeur.ServerShutDown += fonctionArret;
        }

        private void ShowOPC_click(object sender, EventArgs e)
        {
            Object maliste = MonServeur.GetOPCServers();
            Array tab = ToProperArray(maliste);
            for (int j = 0; j < tab.Length; j++)
            {
                ListServeurs.Items.Add(tab.GetValue(j).ToString());
            }
        }

        private Array ToProperArray(object OPCReturn)
        {
            IList myilist = OPCReturn as IList;
            if (myilist != null)
            {
                Type elttype = myilist.GetType().GetElementType();
                Array tab = Array.CreateInstance(elttype, myilist.Count);
                int i = 0;
                foreach (var name in myilist)
                { tab.SetValue(name, i); i++; }
                return tab;
            }
            else
            { return null; }

        }

        private void ListServeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonServeur.ServerName == null)
            {
                MonServeur.Connect(ListServeurs.SelectedItem.ToString());
            }
            else
            {
                MonServeur.Disconnect();
                MonServeur.Connect(ListServeurs.SelectedItem.ToString());
            }
            nomServeur.Text = "Nom du serveur OPC : " + MonServeur.ServerName;
            etatServeur.Text = "Etat du serveur OPC :" + MonServeur.ServerState.ToString();
            heureServeur.Text = "Heure du serveur OPC :" + MonServeur.CurrentTime.ToString();
        }

        private void fonctionArret(string str)
        {
            MessageBox.Show(str);
        }

        private void DisconnectServer_Click(object sender, EventArgs e)
        {
            MonServeur.Disconnect();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            MonGrs = MonServeur.OPCGroups;

            MonGr_Bool = MonGrs.Add("BoolVersClientOPC");
            MonGr_Bool.UpdateRate = 1000;
            MonItems_Bool = MonGr_Bool.OPCItems;

            Array itemIds_Bool = Array.CreateInstance(Type.GetType("System.String"), 4);
            Array clientHandles_Bool = Array.CreateInstance(Type.GetType("System.Int32"), 4);

            itemIds_Bool.SetValue("reso.PLCExchanger.flushvalve", 1);
            clientHandles_Bool.SetValue(10, 1);

            itemIds_Bool.SetValue("reso.PLCExchanger.steamvalve", 2);
            clientHandles_Bool.SetValue(11, 2);

            itemIds_Bool.SetValue("reso.PLCExchanger.feedvalve", 3);
            clientHandles_Bool.SetValue(12, 3);

            Array ServerHandles_Bool, Errors_Bool;

            MonItems_Bool.AddItems(3, itemIds_Bool, clientHandles_Bool, out ServerHandles_Bool, out Errors_Bool);
            
            MonGr_Bool.IsSubscribed = true;

            Array Errs_Bool;
            int cancelID_Bool;

            MonGr_Bool.AsyncRead(3, ServerHandles_Bool, out Errs_Bool, 1, out cancelID_Bool);
            MonGr_Bool.AsyncReadComplete += WhenAsyncReadBoolsComplete;
            MonGr_Bool.DataChange += whenDataChange_Bool;

            MonGr_Float = MonGrs.Add("FloatVersClientOPC");
            MonGr_Float.UpdateRate = 500;
            MonItems_Float = MonGr_Float.OPCItems;

            Array itemIds_Float = Array.CreateInstance(Type.GetType("System.String"), 6);
            Array clientHandles_Float = Array.CreateInstance(Type.GetType("System.Int32"), 6);

            itemIds_Float.SetValue("reso.PLCExchanger.steamtemp", 1);
            clientHandles_Float.SetValue(10, 1);

            itemIds_Float.SetValue("reso.PLCExchanger.tanktemp", 2);
            clientHandles_Float.SetValue(11, 2);

            itemIds_Float.SetValue("reso.PLCExchanger.tanklevel", 3);
            clientHandles_Float.SetValue(12, 3);

            itemIds_Float.SetValue("reso.PLCExchanger.feedflow", 4);
            clientHandles_Float.SetValue(13, 4);

            itemIds_Float.SetValue("reso.PLCExchanger.flushflow", 5);
            clientHandles_Float.SetValue(14, 5);

            Array ServerHandles_Float, Errors_Float;

            MonItems_Float.AddItems(5, itemIds_Float, clientHandles_Float, out ServerHandles_Float, out Errors_Float);

            MonGr_Float.IsSubscribed = true;

            Array Errs_Float;
            int cancelID_Float;

            MonGr_Float.AsyncRead(5, ServerHandles_Float, out Errs_Float, 1, out cancelID_Float);
            MonGr_Float.AsyncReadComplete += WhenAsyncReadFloatComplete;
            MonGr_Float.DataChange += whenDataChange_Float;
        }

        private void whenDataChange_Float(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                addText((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
                triggerAlarm((int)ClientHandles.GetValue(i), ItemValues.GetValue(i), TimeStamps.GetValue(i));
                automaticValve((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
            }
        }

        private void whenDataChange_Bool(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                changeColor((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
            }
        }

        private void WhenAsyncReadFloatComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                addText((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
                triggerAlarm((int)ClientHandles.GetValue(i), ItemValues.GetValue(i), ItemValues.GetValue(i));
                automaticValve((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
            }
        }

        private void WhenAsyncReadBoolsComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                changeColor((int)ClientHandles.GetValue(i), ItemValues.GetValue(i));
            }
        }

        private void automaticValve(int i, object Val)
        {
            if (i == 12)
            {
                if ((float)Val > 3.9)
                {
                    MonItem = MonItems_Bool.AddItem("reso.PLCExchanger.flushvalve", 1);
                    MonItem.Write(true);
                    flushSWITCH.BackColor = System.Drawing.Color.Green;
                }
                if ((float)Val < 0.5)
                {
                    MonItem = MonItems_Bool.AddItem("reso.PLCExchanger.flushvalve", 1);
                    MonItem.Write(false);
                    flushSWITCH.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void triggerAlarm(int i, Object Val, Object TimeStamp)
        {
            String alarm = "";
            String path = "C:/Users/usrlocal/Desktop/TP_Supervision_myWork/TP_Supervision/log/logELASRI.txt";

            if (i == 12)
            {
                if ((float)Val > 3.5)
                {
                    alarm = "Alarme declenché à : " + TimeStamp.ToString() + " -> Le niveau de l'eau dépasse 3.5 m !\n";
                    listAlarmesBox.Items.Add(alarm);
                    File.AppendAllText(path, alarm);
                }
                if ((float)Val < 0.5)
                {
                    alarm = "Alarme declenché à : " + TimeStamp.ToString() + " -> Le niveau de l'eau est dessous de 0.5 m !\n";
                    listAlarmesBox.Items.Add(alarm);
                    File.AppendAllText(path, alarm);
                }
            }

            if (i == 11)
            {
                if (((float)Val > 60))
                    alarm = "Alarme declenché à : " + TimeStamp.ToString() + " -> La température dépasse 60° !\n";
                listAlarmesBox.Items.Add(alarm);
                File.AppendAllText(path, alarm);
            }

            listAlarmesBox.SelectedIndex = listAlarmesBox.Items.Count - 1;
            listAlarmesBox.SelectedIndex = -1;
        }

        private void addText(int i, object val)
        {
            switch(i)
            {
                case 10: 
                    feed_flow_value.Text = val.ToString();
                    break;
                case 11: 
                    tank_temp_value.Text = val.ToString();
                    break;
                case 12:     
                    tank_level_value.Text = val.ToString();
                    int level_tank_white_rectangle = (int)(296 - (float)val * 296 / 4);
                    waterEmpty.Padding = new System.Windows.Forms.Padding(133, level_tank_white_rectangle, 70, 0);
                    break;
                case 13:
                    steam_temp_value.Text = val.ToString();
                    break;
                case 14:
                    flush_flow_value.Text = val.ToString();
                    break;
            }
        }

        private void changeColor(int i, object val)
        {
            if (i == 10)
            {
                if ((bool)val)
                {
                    flushFEED.BackColor = System.Drawing.Color.Green;
                    pipe_Flush.BackColor = System.Drawing.Color.DarkCyan;
                }
                else
                {
                    flushFEED.BackColor = System.Drawing.Color.Red;
                    pipe_Flush.BackColor = System.Drawing.Color.DarkGray;
                }
            }
            if (i == 11)
            {
                if ((bool)val)
                {
                    steamFEED.BackColor = System.Drawing.Color.Green;
                    pipe_Steam.BackColor = System.Drawing.Color.DarkCyan;
                }
                else
                {
                    steamFEED.BackColor = System.Drawing.Color.Red;
                    pipe_Steam.BackColor = System.Drawing.Color.DarkGray;
                }
            }
            if (i == 12)
            {
                if ((bool)val)
                {
                    ledFEED.BackColor = System.Drawing.Color.Green;
                    pipe_Feed.BackColor = System.Drawing.Color.DarkCyan;

                }
                else
                {
                    ledFEED.BackColor = System.Drawing.Color.Red;
                    pipe_Feed.BackColor = System.Drawing.Color.DarkGray;
                }
            }
        }

        private void feedSWITCH_Click(object sender, EventArgs e)
        {
            
            Object val, qualite, horodatage;
            MonItem = MonItems_Bool.AddItem("reso.PLCExchanger.feedvalve", 3);
            MonItem.Read(Convert.ToInt16(OPCDataSource.OPCDevice), out val, out qualite, out horodatage);

            if ((bool)val)
            {
                MonItem.Write(false);
                feedSWITCH.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MonItem.Write(true);
                feedSWITCH.BackColor = System.Drawing.Color.Green;
            }
        }

        private void steamSWITCH_Click(object sender, EventArgs e)
        {
            Object val, qualite, horodatage;
            MonItem = MonItems_Bool.AddItem("reso.PLCExchanger.steamvalve", 2);
            MonItem.Read(Convert.ToInt16(OPCDataSource.OPCDevice), out val, out qualite, out horodatage);

            if ((bool)val)
            {
                MonItem.Write(false);
                steamSWITCH.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MonItem.Write(true);
                steamSWITCH.BackColor = System.Drawing.Color.Green;
            }
        }

        private void flushSWITCH_Click(object sender, EventArgs e)
        {
            Object val, qualite, horodatage;
            MonItem = MonItems_Bool.AddItem("reso.PLCExchanger.flushvalve", 1);
            MonItem.Read(Convert.ToInt16(OPCDataSource.OPCDevice), out val, out qualite, out horodatage);

            if ((bool)val)
            {
                MonItem.Write(false);
                flushSWITCH.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MonItem.Write(true);
                flushSWITCH.BackColor = System.Drawing.Color.Green;
            }
        }

    }

}