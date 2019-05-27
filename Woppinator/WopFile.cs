using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woppinator
{
    public class WopFile
    {
        public delegate void DirtyChanged(bool dirty);

        public event DirtyChanged OnDirtyChanged;

        private bool _dirty;

        /// <summary>
        /// Has this file been modified?
        /// </summary>
        public bool Dirty
        {
            get { return _dirty; }
            set
            {
                _dirty = value;
                if (OnDirtyChanged != null)
                    OnDirtyChanged(_dirty);
            }
        }

        public string ModelName
        {
            get;
            set;
        }

        public string TextureName
        {
            get;
            set;
        }

        public float XScale
        {
            get;
            set;
        }

        public float YScale
        {
            get;
            set;
        }

        public float ZScale
        {
            get;
            set;
        }

        public float XAdjust
        {
            get;
            set;
        }

        public float YAdjust
        {
            get;
            set;
        }

        public float ZAdjust
        {
            get;
            set;
        }

        public float PitchAdjust
        {
            get;
            set;
        }

        public float YawAdjust
        {
            get;
            set;
        }

        public float RollAdjust
        {
            get;
            set;
        }

        public float X
        {
            get;
            set;
        }

        public float Y
        {
            get;
            set;
        }

        public float Z
        {
            get;
            set;
        }

        public float OldX
        {
            get;
            set;
        }

        public float OldY
        {
            get;
            set;
        }

        public float OldZ
        {
            get;
            set;
        }

        public float DX
        {
            get;
            set;
        }

        public float DY
        {
            get;
            set;
        }

        public float DZ
        {
            get;
            set;
        }

        public float Pitch
        {
            get;
            set;
        }

        public float Yaw
        {
            get;
            set;
        }

        public float Roll
        {
            get;
            set;
        }

        public float Pitch2
        {
            get;
            set;
        }

        public float Yaw2
        {
            get;
            set;
        }

        public float Roll2
        {
            get;
            set;
        }

        public float XGoal
        {
            get;
            set;
        }

        public float YGoal
        {
            get;
            set;
        }

        public float ZGoal
        {
            get;
            set;
        }

        public int MovementType
        {
            get;
            set;
        }

        public int MovementTypeData
        {
            get;
            set;
        }

        public float Speed
        {
            get;
            set;
        }

        public float Radius
        {
            get;
            set;
        }

        public int RadiusType
        {
            get;
            set;
        }

        public int CollisionPower
        {
            get;
            set;
        }

        public float PushDX
        {
            get;
            set;
        }

        public float PushDY
        {
            get;
            set;
        }

        public int AttackPower
        {
            get;
            set;
        }

        public int DefensePower
        {
            get;
            set;
        }

        public int DestructionType
        {
            get;
            set;
        }

        public int ID
        {
            get;
            set;
        }

        public int Type
        {
            get;
            set;
        }

        public int SubType
        {
            get;
            set;
        }

        public int Active
        {
            get;
            set;
        }

        public int LastActive
        {
            get;
            set;
        }

        public int ActivationType
        {
            get;
            set;
        }

        public int ActivationSpeed
        {
            get;
            set;
        }

        public int Status
        {
            get;
            set;
        }

        public int Timer
        {
            get;
            set;
        }

        public int TimerMax1
        {
            get;
            set;
        }

        public int TimerMax2
        {
            get;
            set;
        }

        public int Teleportable
        {
            get;
            set;
        }

        public int ButtonPush
        {
            get;
            set;
        }

        public int WaterReact
        {
            get;
            set;
        }

        public int Telekinesisable
        {
            get;
            set;
        }

        public int Freezable
        {
            get;
            set;
        }

        public int Reactive
        {
            get;
            set;
        }

        public int Child
        {
            get;
            set;
        }

        public int Parent
        {
            get;
            set;
        }

        public int Data0
        {
            get;
            set;
        }

        public int Data1
        {
            get;
            set;
        }

        public int Data2
        {
            get;
            set;
        }

        public int Data3
        {
            get;
            set;
        }

        public int Data4
        {
            get;
            set;
        }

        public int Data5
        {
            get;
            set;
        }

        public int Data6
        {
            get;
            set;
        }

        public int Data7
        {
            get;
            set;
        }

        public int Data8
        {
            get;
            set;
        }

        public int Data9
        {
            get;
            set;
        }

        public string TextData0
        {
            get;
            set;
        }

        public string TextData1
        {
            get;
            set;
        }

        public string TextData2
        {
            get;
            set;
        }

        public string TextData3
        {
            get;
            set;
        }

        public int Talkable
        {
            get;
            set;
        }

        public int CurrentAnim
        {
            get;
            set;
        }

        public int StandardAnim
        {
            get;
            set;
        }

        public int TileX
        {
            get;
            set;
        }

        public int TileY
        {
            get;
            set;
        }

        public int TileX2
        {
            get;
            set;
        }

        public int TileY2
        {
            get;
            set;
        }

        public int FutureInt8
        {
            get;
            set;
        }

        public int MovementSpeed
        {
            get;
            set;
        }

        public int FutureInt10
        {
            get;
            set;
        }

        public int FutureInt11
        {
            get;
            set;
        }

        public int FutureInt12
        {
            get;
            set;
        }

        public int FutureInt13
        {
            get;
            set;
        }

        public int FutureInt14
        {
            get;
            set;
        }

        public int FutureInt15
        {
            get;
            set;
        }

        public int FutureInt16
        {
            get;
            set;
        }

        public int Exclamation
        {
            get;
            set;
        }

        public int Shadow
        {
            get;
            set;
        }

        public int Linked
        {
            get;
            set;
        }

        public int LinkBack
        {
            get;
            set;
        }

        public int FutureInt21
        {
            get;
            set;
        }

        public int Frozen
        {
            get;
            set;
        }

        public int FutureInt23
        {
            get;
            set;
        }

        public int FutureInt24
        {
            get;
            set;
        }

        public int FutureInt25
        {
            get;
            set;
        }

        public float ScaleAdjust
        {
            get;
            set;
        }

        public float FutureFloat2
        {
            get;
            set;
        }

        public float FutureFloat3
        {
            get;
            set;
        }

        public float FutureFloat4
        {
            get;
            set;
        }

        public float FutureFloat5
        {
            get;
            set;
        }

        public float FutureFloat6
        {
            get;
            set;
        }

        public float FutureFloat7
        {
            get;
            set;
        }

        public float FutureFloat8
        {
            get;
            set;
        }

        public float FutureFloat9
        {
            get;
            set;
        }

        public float FutureFloat10
        {
            get;
            set;
        }

        public string FutureString1
        {
            get;
            set;
        }

        public string FutureString2
        {
            get;
            set;
        }

        public List<string> Adjusters
        {
            get;
            set;
        }

        public bool this[string s]
        {
            get { return Adjusters.Contains(s); }
            set
            {
                if (value && Adjusters.Count > 30)
                {
                    Console.WriteLine("Too many adjusters (" + (Adjusters.Count + 1) + " > 30)");
                    return;
                }
                if (value)
                {
                    Adjusters.Add(s);
                }
                else
                {
                    Adjusters.Remove(s);
                }
            }
        }

        public WopFile()
        {
            Adjusters = new List<string>();

            ModelName = "!None";
            TextureName = "!None";
            XScale = 1.0f;
            YScale = 1.0f;
            ZScale = 1.0f;
            ID = -1;
            Active = 1001;
            Timer = 1;
            TimerMax1 = 200;
            TimerMax2 = 200;
            ActivationType = 2;
            ActivationSpeed = 20;
            Exclamation = -1;
            TextData0 = "";
            TextData1 = "";
            TextData2 = "";
            TextData3 = "";
            FutureString1 = "";
            FutureString2 = "";
            // TODO: Initialize All Wop Variables
        }

        public static WopFile Read(string path)
        {
            WopFile result = new WopFile();

            Stream s = File.Open(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(s);
            
            result.ModelName = br.ReadBlitzString();
            result.TextureName = br.ReadBlitzString();
            result.XScale = br.ReadSingle();
            result.YScale = br.ReadSingle();
            result.ZScale = br.ReadSingle();
            result.XAdjust = br.ReadSingle();
            result.YAdjust = br.ReadSingle();
            result.ZAdjust = br.ReadSingle();
            result.PitchAdjust = br.ReadSingle();
            result.YawAdjust = br.ReadSingle();
            result.RollAdjust = br.ReadSingle();
            result.X = br.ReadSingle();
            result.Y = br.ReadSingle();
            result.Z = br.ReadSingle();
            result.OldX = br.ReadSingle();
            result.OldY = br.ReadSingle();
            result.OldZ = br.ReadSingle();
            result.DX = br.ReadSingle();
            result.DY = br.ReadSingle();
            result.DZ = br.ReadSingle();
            result.Pitch = br.ReadSingle();
            result.Yaw = br.ReadSingle();
            result.Roll = br.ReadSingle();
            result.Pitch2 = br.ReadSingle();
            result.Yaw2 = br.ReadSingle();
            result.Roll2 = br.ReadSingle();
            result.XGoal = br.ReadSingle();
            result.YGoal = br.ReadSingle();
            result.ZGoal = br.ReadSingle();
            result.MovementType = br.ReadInt32();
            result.MovementTypeData = br.ReadInt32();
            result.Speed = br.ReadSingle();
            result.Radius = br.ReadSingle();
            result.RadiusType = br.ReadInt32();
            result.CollisionPower = br.ReadInt32();
            result.PushDX = br.ReadSingle();
            result.PushDY = br.ReadSingle();
            result.AttackPower = br.ReadInt32();
            result.DefensePower = br.ReadInt32();
            result.DestructionType = br.ReadInt32();
            result.ID = br.ReadInt32();
            result.Type = br.ReadInt32();
            result.SubType = br.ReadInt32();
            result.Active = br.ReadInt32();
            result.LastActive = br.ReadInt32();
            result.ActivationType = br.ReadInt32();
            result.ActivationSpeed = br.ReadInt32();
            result.Status = br.ReadInt32();
            result.Timer = br.ReadInt32();
            result.TimerMax1 = br.ReadInt32();
            result.TimerMax2 = br.ReadInt32();
            result.Teleportable = br.ReadInt32();
            result.ButtonPush = br.ReadInt32();
            result.WaterReact = br.ReadInt32();
            result.Telekinesisable = br.ReadInt32();
            result.Freezable = br.ReadInt32();
            result.Reactive = br.ReadInt32();
            result.Child = br.ReadInt32();
            result.Parent = br.ReadInt32();
            result.Data0 = br.ReadInt32();
            result.Data1 = br.ReadInt32();
            result.Data2 = br.ReadInt32();
            result.Data3 = br.ReadInt32();
            result.Data4 = br.ReadInt32();
            result.Data5 = br.ReadInt32();
            result.Data6 = br.ReadInt32();
            result.Data7 = br.ReadInt32();
            result.Data8 = br.ReadInt32();
            result.Data9 = br.ReadInt32();
            result.TextData0 = br.ReadBlitzString();
            result.TextData1 = br.ReadBlitzString();
            result.TextData2 = br.ReadBlitzString();
            result.TextData3 = br.ReadBlitzString();
            result.Talkable = br.ReadInt32();
            result.CurrentAnim = br.ReadInt32();
            result.StandardAnim = br.ReadInt32();
            result.TileX = br.ReadInt32();
            result.TileY = br.ReadInt32();
            result.TileX2 = br.ReadInt32();
            result.TileY2 = br.ReadInt32();
            result.FutureInt8 = br.ReadInt32();
            result.MovementSpeed = br.ReadInt32();
            result.FutureInt10 = br.ReadInt32();
            result.FutureInt11 = br.ReadInt32();
            result.FutureInt12 = br.ReadInt32();
            result.FutureInt13 = br.ReadInt32();
            result.FutureInt14 = br.ReadInt32();
            result.FutureInt15 = br.ReadInt32();
            result.FutureInt16 = br.ReadInt32();
            result.Exclamation = br.ReadInt32();
            result.Shadow = br.ReadInt32();
            result.Linked = br.ReadInt32();
            result.LinkBack = br.ReadInt32();
            result.FutureInt21 = br.ReadInt32();
            result.Frozen = br.ReadInt32();
            result.FutureInt23 = br.ReadInt32();
            result.FutureInt24 = br.ReadInt32();
            result.FutureInt25 = br.ReadInt32();
            result.ScaleAdjust = br.ReadSingle();
            result.FutureFloat2 = br.ReadInt32();
            result.FutureFloat3 = br.ReadInt32();
            result.FutureFloat4 = br.ReadInt32();
            result.FutureFloat5 = br.ReadInt32();
            result.FutureFloat6 = br.ReadInt32();
            result.FutureFloat7 = br.ReadInt32();
            result.FutureFloat8 = br.ReadInt32();
            result.FutureFloat9 = br.ReadInt32();
            result.FutureFloat10 = br.ReadInt32();
            result.FutureString1 = br.ReadBlitzString();
            result.FutureString2 = br.ReadBlitzString();

            result.Adjusters = new List<string>();
            for (int i = 0; i <= 30; i++)
            {
                if (br.EndOfFile())
                    break;

                string adjuster = br.ReadBlitzString();
                result.Adjusters.Add(adjuster);
            }

            br.Close();

            return result;
        }

        public void Save(string path)
        {
            Stream s = File.Open(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(s);
            
            bw.WriteBlitzString(ModelName);
            bw.WriteBlitzString(TextureName);
            bw.Write(XScale);
            bw.Write(YScale);
            bw.Write(ZScale);
            bw.Write(XAdjust);
            bw.Write(YAdjust);
            bw.Write(ZAdjust);
            bw.Write(PitchAdjust);
            bw.Write(YawAdjust);
            bw.Write(RollAdjust);
            bw.Write(X);
            bw.Write(Y);
            bw.Write(Z);
            bw.Write(OldX);
            bw.Write(OldY);
            bw.Write(OldZ);
            bw.Write(DX);
            bw.Write(DY);
            bw.Write(DZ);
            bw.Write(Pitch);
            bw.Write(Yaw);
            bw.Write(Roll);
            bw.Write(Pitch2);
            bw.Write(Yaw2);
            bw.Write(Roll2);
            bw.Write(XGoal);
            bw.Write(YGoal);
            bw.Write(ZGoal);
            bw.Write(MovementType);
            bw.Write(MovementTypeData);
            bw.Write(Speed);
            bw.Write(Radius);
            bw.Write(RadiusType);
            bw.Write(CollisionPower);
            bw.Write(PushDX);
            bw.Write(PushDY);
            bw.Write(AttackPower);
            bw.Write(DefensePower);
            bw.Write(DestructionType);
            bw.Write(ID);
            bw.Write(Type);
            bw.Write(SubType);
            bw.Write(Active);
            bw.Write(LastActive);
            bw.Write(ActivationType);
            bw.Write(ActivationSpeed);
            bw.Write(Status);
            bw.Write(Timer);
            bw.Write(TimerMax1);
            bw.Write(TimerMax2);
            bw.Write(Teleportable);
            bw.Write(ButtonPush);
            bw.Write(WaterReact);
            bw.Write(Telekinesisable);
            bw.Write(Freezable);
            bw.Write(Reactive);
            bw.Write(Child);
            bw.Write(Parent);
            bw.Write(Data0);
            bw.Write(Data1);
            bw.Write(Data2);
            bw.Write(Data3);
            bw.Write(Data4);
            bw.Write(Data5);
            bw.Write(Data6);
            bw.Write(Data7);
            bw.Write(Data8);
            bw.Write(Data9);
            bw.WriteBlitzString(TextData0);
            bw.WriteBlitzString(TextData1);
            bw.WriteBlitzString(TextData2);
            bw.WriteBlitzString(TextData3);
            bw.Write(Talkable);
            bw.Write(CurrentAnim);
            bw.Write(StandardAnim);
            bw.Write(TileX);
            bw.Write(TileY);
            bw.Write(TileX2);
            bw.Write(TileY2);
            bw.Write(FutureInt8);
            bw.Write(MovementSpeed);
            bw.Write(FutureInt10);
            bw.Write(FutureInt11);
            bw.Write(FutureInt12);
            bw.Write(FutureInt13);
            bw.Write(FutureInt14);
            bw.Write(FutureInt15);
            bw.Write(FutureInt16);
            bw.Write(Exclamation);
            bw.Write(Shadow);
            bw.Write(Linked);
            bw.Write(LinkBack);
            bw.Write(FutureInt21);
            bw.Write(Frozen);
            bw.Write(FutureInt23);
            bw.Write(FutureInt24);
            bw.Write(FutureInt25);
            bw.Write(ScaleAdjust);
            bw.Write(FutureFloat2);
            bw.Write(FutureFloat3);
            bw.Write(FutureFloat4);
            bw.Write(FutureFloat5);
            bw.Write(FutureFloat6);
            bw.Write(FutureFloat7);
            bw.Write(FutureFloat8);
            bw.Write(FutureFloat9);
            bw.Write(FutureFloat10);
            bw.WriteBlitzString(FutureString1);
            bw.WriteBlitzString(FutureString2);
            
            for (int i = 0; i < Adjusters.Count; i++)
            {
                if (i > 30)
                {
                    Console.WriteLine("Too many adjusters (" + Adjusters.Count + " > 30)");
                    break;
                }
                bw.WriteBlitzString(Adjusters[i]);
            }

            bw.Flush();
            bw.Close();
        }
    }
}
