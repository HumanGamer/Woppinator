using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woppinator
{
    public partial class EditWopCtrl : UserControl
    {
        private WopFile _selectedWopFile;

        public WopFile SelectedWopFile
        {
            get
            {
                return _selectedWopFile;
            }
            set
            {
                _selectedWopFile = value;
                OnWopChanged();
            }
        }

        public EditWopCtrl()
        {
            InitializeComponent();
        }

        protected void OnWopChanged()
        {
            if (SelectedWopFile == null)
                return;

            txtModel.Text = SelectedWopFile.ModelName;
            txtTexture.Text = SelectedWopFile.TextureName;
            chkTexture.Checked = SelectedWopFile["TextureName"];
            nudXScale.Value = (decimal)SelectedWopFile.XScale;
            chkXScale.Checked = SelectedWopFile["XScale"];
            nudYScale.Value = (decimal)SelectedWopFile.YScale;
            chkYScale.Checked = SelectedWopFile["YScale"];
            nudZScale.Value = (decimal)SelectedWopFile.ZScale;
            chkZScale.Checked = SelectedWopFile["ZScale"];

            nudXAdjust.Value = (decimal)SelectedWopFile.XAdjust;
            chkXAdjust.Checked = SelectedWopFile["XAdjust"];
            nudYAdjust.Value = (decimal)SelectedWopFile.YAdjust;
            chkYAdjust.Checked = SelectedWopFile["YAdjust"];
            nudZAdjust.Value = (decimal)SelectedWopFile.ZAdjust;
            chkZAdjust.Checked = SelectedWopFile["ZAdjust"];

            nudPitchAdjust.Value = (decimal) SelectedWopFile.PitchAdjust;
            chkPitchAdjust.Checked = SelectedWopFile["PitchAdjust"];
            nudYawAdjust.Value = (decimal)SelectedWopFile.YawAdjust;
            chkYawAdjust.Checked = SelectedWopFile["YawAdjust"];
            nudRollAdjust.Value = (decimal)SelectedWopFile.RollAdjust;
            chkRollAdjust.Checked = SelectedWopFile["RollAdjust"];

            nudX.Value = (decimal)SelectedWopFile.X;
            nudY.Value = (decimal)SelectedWopFile.Y;
            nudZ.Value = (decimal)SelectedWopFile.Z;

            nudID.Value = SelectedWopFile.ID;
            chkID.Checked = SelectedWopFile["ID"];
            nudType.Value = SelectedWopFile.Type;
            chkType.Checked = SelectedWopFile["Type"];
            nudSubType.Value = SelectedWopFile.SubType;
            chkSubType.Checked = SelectedWopFile["SubType"];
            
            chkActiveVal.Checked = SelectedWopFile.Active == 1001;
            chkActive.Checked = SelectedWopFile["Active"];

            nudTimer.Value = SelectedWopFile.Timer;
            chkTimer.Checked = SelectedWopFile["Timer"];
            nudTimerMax1.Value = SelectedWopFile.TimerMax1;
            chkTimerMax1.Checked = SelectedWopFile["TimerMax1"];
            nudTimerMax2.Value = SelectedWopFile.TimerMax2;
            chkTimerMax2.Checked = SelectedWopFile["TimerMax2"];
            nudWaterReact.Value = SelectedWopFile.WaterReact;
            chkWaterReact.Checked = SelectedWopFile["WaterReact"];
            nudTalkable.Value = SelectedWopFile.Talkable;
            chkTalkable.Checked = SelectedWopFile["Talkable"];

            nudActivationType.Value = SelectedWopFile.ActivationType;
            chkActivationType.Checked = SelectedWopFile["ActivationType"];
            nudActivationSpeed.Value = SelectedWopFile.ActivationSpeed;
            chkActivationSpeed.Checked = SelectedWopFile["ActivationSpeed"];
            nudMovementSpeed.Value = SelectedWopFile.MovementSpeed;
            chkMovementSpeed.Checked = SelectedWopFile["MovementSpeed"];
            nudExclamation.Value = SelectedWopFile.Exclamation;
            chkExclamation.Checked = SelectedWopFile["Exclamation"];
            nudScaleAdjust.Value = (decimal)SelectedWopFile.ScaleAdjust;
            chkScaleAdjust.Checked = SelectedWopFile["ScaleAdjust"];

            nudData0.Value = SelectedWopFile.Data0;
            chkData0.Checked = SelectedWopFile["Data0"];
            nudData1.Value = SelectedWopFile.Data1;
            chkData1.Checked = SelectedWopFile["Data1"];
            nudData2.Value = SelectedWopFile.Data2;
            chkData2.Checked = SelectedWopFile["Data2"];
            nudData3.Value = SelectedWopFile.Data3;
            chkData3.Checked = SelectedWopFile["Data3"];
            nudData4.Value = SelectedWopFile.Data4;
            chkData4.Checked = SelectedWopFile["Data4"];
            nudData5.Value = SelectedWopFile.Data5;
            chkData5.Checked = SelectedWopFile["Data5"];
            nudData6.Value = SelectedWopFile.Data6;
            chkData6.Checked = SelectedWopFile["Data6"];
            nudData7.Value = SelectedWopFile.Data7;
            chkData7.Checked = SelectedWopFile["Data7"];
            nudData8.Value = SelectedWopFile.Data8;
            chkData8.Checked = SelectedWopFile["Data8"];
            nudData9.Value = SelectedWopFile.Data9;
            chkData9.Checked = SelectedWopFile["Data9"];
            nudMovementType.Value = SelectedWopFile.MovementType;
            nudMovementTypeData.Value = SelectedWopFile.MovementTypeData;
            txtTextData0.Text = SelectedWopFile.TextData0;
            chkTextData0.Checked = SelectedWopFile["ObjectTextData0"];
            txtTextData1.Text = SelectedWopFile.TextData1;
            txtTextData2.Text = SelectedWopFile.TextData2;
            txtTextData3.Text = SelectedWopFile.TextData3;
            nudAttackPower.Value = SelectedWopFile.AttackPower;
            nudDefensePower.Value = SelectedWopFile.DefensePower;
            chkDefensePower.Checked = SelectedWopFile["DefensePower"];

            nudOldX.Value = (decimal)SelectedWopFile.OldX;
            nudOldY.Value = (decimal)SelectedWopFile.OldY;
            nudOldZ.Value = (decimal)SelectedWopFile.OldZ;

            nudDX.Value = (decimal) SelectedWopFile.DX;
            nudDY.Value = (decimal)SelectedWopFile.DY;
            nudDZ.Value = (decimal)SelectedWopFile.DZ;

            nudPitch.Value = (decimal) SelectedWopFile.Pitch;
            nudYaw.Value = (decimal) SelectedWopFile.Yaw;
            nudRoll.Value = (decimal) SelectedWopFile.Roll;

            nudPitch2.Value = (decimal)SelectedWopFile.Pitch2;
            nudYaw2.Value = (decimal)SelectedWopFile.Yaw2;
            nudRoll2.Value = (decimal)SelectedWopFile.Roll2;

            nudXGoal.Value = (decimal)SelectedWopFile.XGoal;
            nudYGoal.Value = (decimal)SelectedWopFile.YGoal;
            nudZGoal.Value = (decimal)SelectedWopFile.ZGoal;

            nudSpeed.Value = (decimal)SelectedWopFile.Speed;
            nudRadius.Value = (decimal)SelectedWopFile.Radius;
            nudRadiusType.Value = SelectedWopFile.RadiusType;
            nudCollisionPower.Value = SelectedWopFile.CollisionPower;
            nudPushDX.Value = (decimal)SelectedWopFile.PushDX;
            nudPushDY.Value = (decimal)SelectedWopFile.PushDY;
            nudDestructionType.Value = SelectedWopFile.DestructionType;
            nudLastActive.Value = SelectedWopFile.LastActive;
            nudStatus.Value = SelectedWopFile.Status;
            nudTeleportable.Value = SelectedWopFile.Teleportable;
            nudButtonPush.Value = SelectedWopFile.ButtonPush;
            nudTelekinesisable.Value = SelectedWopFile.Telekinesisable;
            nudFreezable.Value = SelectedWopFile.Freezable;
            nudReactive.Value = SelectedWopFile.Reactive;
            nudChild.Value = SelectedWopFile.Child;
            nudParent.Value = SelectedWopFile.Parent;
            nudCurrentAnim.Value = SelectedWopFile.CurrentAnim;
            nudStandardAnim.Value = SelectedWopFile.StandardAnim;
            nudTileX.Value = SelectedWopFile.TileX;
            nudTileY.Value = SelectedWopFile.TileY;
            nudTileX2.Value = SelectedWopFile.TileX2;
            nudTileY2.Value = SelectedWopFile.TileY2;
            nudFutureInt8.Value = SelectedWopFile.FutureInt8;
            nudFutureInt10.Value = SelectedWopFile.FutureInt10;
            nudFutureInt11.Value = SelectedWopFile.FutureInt11;
            nudFutureInt12.Value = SelectedWopFile.FutureInt12;
            nudFutureInt13.Value = SelectedWopFile.FutureInt13;
            nudFutureInt14.Value = SelectedWopFile.FutureInt14;
            nudFutureInt15.Value = SelectedWopFile.FutureInt15;
            nudFutureInt16.Value = SelectedWopFile.FutureInt16;
            nudShadow.Value = SelectedWopFile.Shadow;
            nudLinked.Value = SelectedWopFile.Linked;
            nudLinkBack.Value = SelectedWopFile.LinkBack;
            nudFutureInt21.Value = SelectedWopFile.FutureInt21;
            nudFrozen.Value = SelectedWopFile.Frozen;
            nudFutureInt23.Value = SelectedWopFile.FutureInt23;
            nudFutureInt24.Value = SelectedWopFile.FutureInt24;
            nudFutureInt25.Value = SelectedWopFile.FutureInt25;
            nudFutureFloat2.Value = (decimal)SelectedWopFile.FutureFloat2;
            nudFutureFloat3.Value = (decimal)SelectedWopFile.FutureFloat3;
            nudFutureFloat4.Value = (decimal)SelectedWopFile.FutureFloat4;
            nudFutureFloat5.Value = (decimal)SelectedWopFile.FutureFloat5;
            nudFutureFloat6.Value = (decimal)SelectedWopFile.FutureFloat6;
            nudFutureFloat7.Value = (decimal)SelectedWopFile.FutureFloat7;
            nudFutureFloat8.Value = (decimal)SelectedWopFile.FutureFloat8;
            nudFutureFloat9.Value = (decimal)SelectedWopFile.FutureFloat9;
            nudFutureFloat10.Value = (decimal)SelectedWopFile.FutureFloat10;
            txtFutureString1.Text = SelectedWopFile.FutureString1;
            txtFutureString2.Text = SelectedWopFile.FutureString2;
        }

        public WopFile GetFinalWopFile()
        {
            WopFile result = new WopFile();

            result.ModelName = txtModel.Text;
            result.TextureName = txtTexture.Text;
            result["TextureName"] = chkTexture.Checked;
            result.XScale = (float)nudXScale.Value;
            result["XScale"] = chkXScale.Checked;
            result.YScale = (float)nudYScale.Value;
            result["YScale"] = chkYScale.Checked;
            result.ZScale = (float)nudZScale.Value;
            result["ZScale"] = chkZScale.Checked;
            result.XAdjust = (float) nudXAdjust.Value;
            result["XAdjust"] = chkXAdjust.Checked;
            result.YAdjust = (float)nudYAdjust.Value;
            result["YAdjust"] = chkYAdjust.Checked;
            result.ZAdjust = (float)nudZAdjust.Value;
            result["ZAdjust"] = chkZAdjust.Checked;
            result.PitchAdjust = (float) nudPitchAdjust.Value;
            result["PitchAdjust"] = chkPitchAdjust.Checked;
            result.YawAdjust = (float)nudYawAdjust.Value;
            result["YawAdjust"] = chkYawAdjust.Checked;
            result.RollAdjust = (float)nudRollAdjust.Value;
            result["RollAdjust"] = chkRollAdjust.Checked;
            result.X = (float)nudX.Value;
            result.Y = (float)nudY.Value;
            result.Z = (float)nudZ.Value;
            result.ID = (int)nudID.Value;
            result["ID"] = chkID.Checked;
            result.Type = (int)nudType.Value;
            result["Type"] = chkType.Checked;
            result.SubType = (int)nudSubType.Value;
            result["SubType"] = chkSubType.Checked;

            result.Active = chkActiveVal.Checked ? 1001 : 0;
            result["Active"] = chkActive.Checked;

            result.Timer = (int)nudTimer.Value;
            result["Timer"] = chkTimer.Checked;
            result.TimerMax1 = (int)nudTimerMax1.Value;
            result["TimerMax1"] = chkTimerMax1.Checked;
            result.TimerMax2 = (int)nudTimerMax2.Value;
            result["TimerMax2"] = chkTimerMax2.Checked;
            result.WaterReact = (int)nudWaterReact.Value;
            result["WaterReact"] = chkWaterReact.Checked;
            result.Talkable = (int)nudTalkable.Value;
            result["Talkable"] = chkTalkable.Checked;

            result.ActivationType = (int)nudActivationType.Value;
            result["ActivationType"] = chkActivationType.Checked;
            result.ActivationSpeed = (int) nudActivationSpeed.Value;
            result["ActivationSpeed"] = chkActivationSpeed.Checked;
            result.MovementSpeed = (int) nudMovementSpeed.Value;
            result["MovementSpeed"] = chkMovementSpeed.Checked;
            result.Exclamation = (int) nudExclamation.Value;
            result["Exclamation"] = chkExclamation.Checked;
            result.ScaleAdjust = (float) nudScaleAdjust.Value;
            result["ScaleAdjust"] = chkScaleAdjust.Checked;

            result.Data0 = (int)nudData0.Value;
            result["Data0"] = chkData0.Checked;
            result.Data1 = (int)nudData1.Value;
            result["Data1"] = chkData1.Checked;
            result.Data2 = (int)nudData2.Value;
            result["Data2"] = chkData2.Checked;
            result.Data3 = (int)nudData3.Value;
            result["Data3"] = chkData3.Checked;
            result.Data4 = (int)nudData4.Value;
            result["Data4"] = chkData4.Checked;
            result.Data5 = (int)nudData5.Value;
            result["Data5"] = chkData5.Checked;
            result.Data6 = (int)nudData6.Value;
            result["Data6"] = chkData6.Checked;
            result.Data7 = (int)nudData7.Value;
            result["Data7"] = chkData7.Checked;
            result.Data8 = (int)nudData8.Value;
            result["Data8"] = chkData8.Checked;
            result.Data9 = (int)nudData9.Value;
            result["Data9"] = chkData9.Checked;
            result.MovementType = (int) nudMovementType.Value;
            result.MovementTypeData = (int) nudMovementTypeData.Value;
            result.TextData0 = txtTextData0.Text;
            result["ObjectTextData0"] = chkTextData0.Checked;
            result.TextData1 = txtTextData1.Text;
            result.TextData2 = txtTextData2.Text;
            result.TextData3 = txtTextData3.Text;
            result.AttackPower = (int)nudAttackPower.Value;
            result.DefensePower = (int)nudDefensePower.Value;
            result["DefensePower"] = chkDefensePower.Checked;

            result.OldX = (float) nudOldX.Value;
            result.OldY = (float) nudOldY.Value;
            result.OldZ = (float) nudOldZ.Value;

            result.DX = (float) nudDX.Value;
            result.DY = (float) nudDY.Value;
            result.DZ = (float) nudDZ.Value;

            result.Pitch = (float) nudPitch.Value;
            result.Yaw = (float) nudYaw.Value;
            result.Roll = (float) nudRoll.Value;

            result.Pitch2 = (float) nudPitch2.Value;
            result.Yaw2 = (float) nudYaw2.Value;
            result.Roll2 = (float) nudRoll2.Value;

            result.XGoal = (float) nudXGoal.Value;
            result.YGoal = (float) nudYGoal.Value;
            result.ZGoal = (float) nudZGoal.Value;

            result.Speed = (float) nudSpeed.Value;
            result.Radius = (float)nudRadius.Value;
            result.RadiusType = (int) nudRadiusType.Value;
            result.CollisionPower = (int) nudCollisionPower.Value;
            result.PushDX = (float) nudPushDX.Value;
            result.PushDY = (float) nudPushDY.Value;
            result.DestructionType = (int) nudDestructionType.Value;
            result.LastActive = (int)nudLastActive.Value;
            result.Status = (int)nudStatus.Value;
            result.Teleportable = (int)nudTeleportable.Value;
            result.ButtonPush = (int)nudButtonPush.Value;
            result.Telekinesisable = (int)nudTelekinesisable.Value;
            result.Freezable = (int)nudFreezable.Value;
            result.Reactive = (int)nudReactive.Value;
            result.Child = (int)nudChild.Value;
            result.Parent = (int)nudParent.Value;
            result.CurrentAnim = (int)nudCurrentAnim.Value;
            result.StandardAnim = (int)nudStandardAnim.Value;
            result.TileX = (int)nudTileX.Value;
            result.TileY = (int)nudTileY.Value;
            result.TileX2 = (int)nudTileX2.Value;
            result.TileY2 = (int)nudTileY2.Value;
            result.FutureInt8 = (int)nudFutureInt8.Value;
            result.FutureInt10 = (int)nudFutureInt10.Value;
            result.FutureInt11 = (int)nudFutureInt11.Value;
            result.FutureInt12 = (int)nudFutureInt12.Value;
            result.FutureInt13 = (int)nudFutureInt13.Value;
            result.FutureInt14 = (int)nudFutureInt14.Value;
            result.FutureInt15 = (int)nudFutureInt15.Value;
            result.FutureInt16 = (int)nudFutureInt16.Value;
            result.Shadow = (int)nudShadow.Value;
            result.Linked = (int)nudLinked.Value;
            result.LinkBack = (int)nudLinkBack.Value;
            result.FutureInt21 = (int)nudFutureInt21.Value;
            result.Frozen = (int)nudFrozen.Value;
            result.FutureInt23 = (int)nudFutureInt23.Value;
            result.FutureInt24 = (int)nudFutureInt24.Value;
            result.FutureInt25 = (int)nudFutureInt25.Value;
            result.FutureFloat2 = (float)nudFutureFloat2.Value;
            result.FutureFloat3 = (float)nudFutureFloat3.Value;
            result.FutureFloat4 = (float)nudFutureFloat4.Value;
            result.FutureFloat5 = (float)nudFutureFloat5.Value;
            result.FutureFloat6 = (float)nudFutureFloat6.Value;
            result.FutureFloat7 = (float)nudFutureFloat7.Value;
            result.FutureFloat8 = (float)nudFutureFloat8.Value;
            result.FutureFloat9 = (float)nudFutureFloat9.Value;
            result.FutureFloat10 = (float)nudFutureFloat10.Value;
            result.FutureString1 = txtFutureString1.Text;
            result.FutureString2 = txtFutureString2.Text;

            return result;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text != SelectedWopFile.ModelName)
                SelectedWopFile.Dirty = true;
        }

        private void txtTexture_TextChanged(object sender, EventArgs e)
        {
            if (txtTexture.Text != SelectedWopFile.TextureName)
                SelectedWopFile.Dirty = true;
        }

        private void chkTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTexture.Checked != SelectedWopFile["TextureName"])
                SelectedWopFile.Dirty = true;
        }

        private void nudXScale_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudXScale.Value - SelectedWopFile.XScale) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkXScale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXScale.Checked != SelectedWopFile["XScale"])
                SelectedWopFile.Dirty = true;
        }

        private void nudYScale_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYScale.Value - SelectedWopFile.YScale) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkYScale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYScale.Checked != SelectedWopFile["YScale"])
                SelectedWopFile.Dirty = true;
        }

        private void nudZScale_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudZScale.Value - SelectedWopFile.ZScale) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkZScale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkZScale.Checked != SelectedWopFile["ZScale"])
                SelectedWopFile.Dirty = true;
        }

        private void nudXAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float) nudXAdjust.Value - SelectedWopFile.XAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkXAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXAdjust.Checked != SelectedWopFile["XAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudYAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYAdjust.Value - SelectedWopFile.YAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkYAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYAdjust.Checked != SelectedWopFile["YAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudZAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudZAdjust.Value - SelectedWopFile.ZAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkZAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkZAdjust.Checked != SelectedWopFile["ZAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudPitchAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudPitchAdjust.Value - SelectedWopFile.PitchAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkPitchAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPitchAdjust.Checked != SelectedWopFile["PitchAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudYawAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYawAdjust.Value - SelectedWopFile.YawAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkYawAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYawAdjust.Checked != SelectedWopFile["YawAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudRollAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudRollAdjust.Value - SelectedWopFile.RollAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkRollAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRollAdjust.Checked != SelectedWopFile["RollAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudX.Value - SelectedWopFile.X) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudY.Value - SelectedWopFile.Y) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudZ_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudZ.Value - SelectedWopFile.Z) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            if (nudID.Value != SelectedWopFile.ID)
                SelectedWopFile.Dirty = true;
        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkID.Checked != SelectedWopFile["ID"])
                SelectedWopFile.Dirty = true;
        }

        private void nudType_ValueChanged(object sender, EventArgs e)
        {
            if (nudType.Value != SelectedWopFile.Type)
                SelectedWopFile.Dirty = true;
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType.Checked != SelectedWopFile["Type"])
                SelectedWopFile.Dirty = true;
        }

        private void nudSubType_ValueChanged(object sender, EventArgs e)
        {
            if (nudSubType.Value != SelectedWopFile.SubType)
                SelectedWopFile.Dirty = true;
        }

        private void chkSubType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubType.Checked != SelectedWopFile["SubType"])
                SelectedWopFile.Dirty = true;
        }

        private void chkActiveVal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiveVal.Checked != (SelectedWopFile.Active == 1001))
                SelectedWopFile.Dirty = true;
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked != SelectedWopFile["Active"])
                SelectedWopFile.Dirty = true;
        }

        private void nudTimer_ValueChanged(object sender, EventArgs e)
        {
            if (nudTimer.Value != SelectedWopFile.Timer)
                SelectedWopFile.Dirty = true;
        }

        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimer.Checked != SelectedWopFile["Timer"])
                SelectedWopFile.Dirty = true;
        }

        private void nudTimerMax1_ValueChanged(object sender, EventArgs e)
        {
            if (nudTimerMax1.Value != SelectedWopFile.TimerMax1)
                SelectedWopFile.Dirty = true;
        }

        private void chkTimerMax1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimerMax1.Checked != SelectedWopFile["TimerMax1"])
                SelectedWopFile.Dirty = true;
        }

        private void nudTimerMax2_ValueChanged(object sender, EventArgs e)
        {
            if (nudTimerMax2.Value != SelectedWopFile.TimerMax2)
                SelectedWopFile.Dirty = true;
        }

        private void chkTimerMax2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimerMax2.Checked != SelectedWopFile["TimerMax2"])
                SelectedWopFile.Dirty = true;
        }

        private void nudWaterReact_ValueChanged(object sender, EventArgs e)
        {
            if (nudWaterReact.Value != SelectedWopFile.WaterReact)
                SelectedWopFile.Dirty = true;
        }

        private void chkWaterReact_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWaterReact.Checked != SelectedWopFile["WaterReact"])
                SelectedWopFile.Dirty = true;
        }

        private void nudTalkable_ValueChanged(object sender, EventArgs e)
        {
            if (nudTalkable.Value != SelectedWopFile.Talkable)
                SelectedWopFile.Dirty = true;
        }

        private void chkTalkable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTalkable.Checked != SelectedWopFile["Talkable"])
                SelectedWopFile.Dirty = true;
        }

        private void nudActivationType_ValueChanged(object sender, EventArgs e)
        {
            if (nudActivationType.Value != SelectedWopFile.ActivationType)
                SelectedWopFile.Dirty = true;
        }

        private void chkActivationType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivationType.Checked != SelectedWopFile["ActivationType"])
                SelectedWopFile.Dirty = true;
        }

        private void nudActivationSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (nudActivationSpeed.Value != SelectedWopFile.ActivationSpeed)
                SelectedWopFile.Dirty = true;
        }

        private void chkActivationSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivationSpeed.Checked != SelectedWopFile["ActivationSpeed"])
                SelectedWopFile.Dirty = true;
        }

        private void nudMovementSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (nudMovementSpeed.Value != SelectedWopFile.MovementSpeed)
                SelectedWopFile.Dirty = true;
        }

        private void chkMovementSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMovementSpeed.Checked != SelectedWopFile["MovementSpeed"])
                SelectedWopFile.Dirty = true;
        }

        private void nudExclamation_ValueChanged(object sender, EventArgs e)
        {
            if (nudExclamation.Value != SelectedWopFile.Exclamation)
                SelectedWopFile.Dirty = true;
        }

        private void chkExclamation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExclamation.Checked != SelectedWopFile["Exclamation"])
                SelectedWopFile.Dirty = true;
        }

        private void nudScaleAdjust_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudScaleAdjust.Value - SelectedWopFile.ScaleAdjust) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void chkScaleAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScaleAdjust.Checked != SelectedWopFile["ScaleAdjust"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData0_ValueChanged(object sender, EventArgs e)
        {
            if (nudData0.Value != SelectedWopFile.Data0)
                SelectedWopFile.Dirty = true;
        }

        private void chkData0_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData0.Checked != SelectedWopFile["Data0"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData1_ValueChanged(object sender, EventArgs e)
        {
            if (nudData1.Value != SelectedWopFile.Data1)
                SelectedWopFile.Dirty = true;
        }

        private void chkData1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData1.Checked != SelectedWopFile["Data1"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData2_ValueChanged(object sender, EventArgs e)
        {
            if (nudData2.Value != SelectedWopFile.Data2)
                SelectedWopFile.Dirty = true;
        }

        private void chkData2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData2.Checked != SelectedWopFile["Data2"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData3_ValueChanged(object sender, EventArgs e)
        {
            if (nudData3.Value != SelectedWopFile.Data3)
                SelectedWopFile.Dirty = true;
        }

        private void chkData3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData3.Checked != SelectedWopFile["Data3"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData4_ValueChanged(object sender, EventArgs e)
        {
            if (nudData4.Value != SelectedWopFile.Data4)
                SelectedWopFile.Dirty = true;
        }

        private void chkData4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData4.Checked != SelectedWopFile["Data4"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData5_ValueChanged(object sender, EventArgs e)
        {
            if (nudData5.Value != SelectedWopFile.Data5)
                SelectedWopFile.Dirty = true;
        }

        private void chkData5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData5.Checked != SelectedWopFile["Data5"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData6_ValueChanged(object sender, EventArgs e)
        {
            if (nudData6.Value != SelectedWopFile.Data6)
                SelectedWopFile.Dirty = true;
        }

        private void chkData6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData6.Checked != SelectedWopFile["Data6"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData7_ValueChanged(object sender, EventArgs e)
        {
            if (nudData7.Value != SelectedWopFile.Data7)
                SelectedWopFile.Dirty = true;
        }

        private void chkData7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData7.Checked != SelectedWopFile["Data7"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData8_ValueChanged(object sender, EventArgs e)
        {
            if (nudData8.Value != SelectedWopFile.Data8)
                SelectedWopFile.Dirty = true;
        }

        private void chkData8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData8.Checked != SelectedWopFile["Data8"])
                SelectedWopFile.Dirty = true;
        }

        private void nudData9_ValueChanged(object sender, EventArgs e)
        {
            if (nudData9.Value != SelectedWopFile.Data9)
                SelectedWopFile.Dirty = true;
        }

        private void chkData9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData9.Checked != SelectedWopFile["Data9"])
                SelectedWopFile.Dirty = true;
        }

        private void nudMovementType_ValueChanged(object sender, EventArgs e)
        {
            if (nudMovementType.Value != SelectedWopFile.MovementType)
                SelectedWopFile.Dirty = true;
        }

        private void nudMovementTypeData_ValueChanged(object sender, EventArgs e)
        {
            if (nudMovementTypeData.Value != SelectedWopFile.MovementTypeData)
                SelectedWopFile.Dirty = true;
        }

        private void txtTextData0_TextChanged(object sender, EventArgs e)
        {
            if (txtTextData0.Text != SelectedWopFile.TextData0)
                SelectedWopFile.Dirty = true;
        }

        private void chkTextData0_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTextData0.Checked != SelectedWopFile["ObjectTextData0"])
                SelectedWopFile.Dirty = true;
        }

        private void txtTextData1_TextChanged(object sender, EventArgs e)
        {
            if (txtTextData1.Text != SelectedWopFile.TextData1)
                SelectedWopFile.Dirty = true;
        }

        private void txtTextData2_TextChanged(object sender, EventArgs e)
        {
            if (txtTextData2.Text != SelectedWopFile.TextData2)
                SelectedWopFile.Dirty = true;
        }

        private void txtTextData3_TextChanged(object sender, EventArgs e)
        {
            if (txtTextData3.Text != SelectedWopFile.TextData3)
                SelectedWopFile.Dirty = true;
        }

        private void nudAttackPower_ValueChanged(object sender, EventArgs e)
        {
            if (nudAttackPower.Value != SelectedWopFile.AttackPower)
                SelectedWopFile.Dirty = true;
        }

        private void nudDefensePower_ValueChanged(object sender, EventArgs e)
        {
            if (nudDefensePower.Value != SelectedWopFile.DefensePower)
                SelectedWopFile.Dirty = true;
        }

        private void chkDefensePower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDefensePower.Checked != SelectedWopFile["DefensePower"])
                SelectedWopFile.Dirty = true;
        }

        private void nudOldX_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudOldX.Value - SelectedWopFile.OldX) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudOldY_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudOldY.Value - SelectedWopFile.OldY) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudOldZ_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudOldZ.Value - SelectedWopFile.OldZ) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudDX_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudDX.Value - SelectedWopFile.DX) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudDY_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudDY.Value - SelectedWopFile.DY) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudDZ_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudDZ.Value - SelectedWopFile.DZ) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudPitch_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudPitch.Value - SelectedWopFile.Pitch) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudYaw_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYaw.Value - SelectedWopFile.Yaw) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudRoll_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudRoll.Value - SelectedWopFile.Roll) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudPitch2_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudPitch2.Value - SelectedWopFile.Pitch2) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudYaw2_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYaw2.Value - SelectedWopFile.Yaw2) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudRoll2_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudRoll2.Value - SelectedWopFile.Roll2) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudXGoal_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudXGoal.Value - SelectedWopFile.XGoal) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudYGoal_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudYGoal.Value - SelectedWopFile.YGoal) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudZGoal_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudZGoal.Value - SelectedWopFile.ZGoal) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudSpeed.Value - SelectedWopFile.Speed) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudRadius.Value - SelectedWopFile.Radius) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudRadiusType_ValueChanged(object sender, EventArgs e)
        {
            if (nudRadiusType.Value != SelectedWopFile.RadiusType)
                SelectedWopFile.Dirty = true;
        }

        private void nudCollisionPower_ValueChanged(object sender, EventArgs e)
        {
            if (nudCollisionPower.Value != SelectedWopFile.CollisionPower)
                SelectedWopFile.Dirty = true;
        }

        private void nudPushDX_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudPushDX.Value - SelectedWopFile.PushDX) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudPushDY_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudPushDY.Value - SelectedWopFile.PushDY) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudDestructionType_ValueChanged(object sender, EventArgs e)
        {
            if (nudDestructionType.Value != SelectedWopFile.DestructionType)
                SelectedWopFile.Dirty = true;
        }

        private void nudLastActive_ValueChanged(object sender, EventArgs e)
        {
            if (nudLastActive.Value != SelectedWopFile.LastActive)
                SelectedWopFile.Dirty = true;
        }

        private void nudStatus_ValueChanged(object sender, EventArgs e)
        {
            if (nudStatus.Value != SelectedWopFile.Status)
                SelectedWopFile.Dirty = true;
        }

        private void nudTeleportable_ValueChanged(object sender, EventArgs e)
        {
            if (nudTeleportable.Value != SelectedWopFile.Teleportable)
                SelectedWopFile.Dirty = true;
        }

        private void nudButtonPush_ValueChanged(object sender, EventArgs e)
        {
            if (nudButtonPush.Value != SelectedWopFile.ButtonPush)
                SelectedWopFile.Dirty = true;
        }

        private void nudTelekinesisable_ValueChanged(object sender, EventArgs e)
        {
            if (nudTelekinesisable.Value != SelectedWopFile.Telekinesisable)
                SelectedWopFile.Dirty = true;
        }

        private void nudFreezable_ValueChanged(object sender, EventArgs e)
        {
            if (nudFreezable.Value != SelectedWopFile.Freezable)
                SelectedWopFile.Dirty = true;
        }

        private void nudReactive_ValueChanged(object sender, EventArgs e)
        {
            if (nudReactive.Value != SelectedWopFile.Reactive)
                SelectedWopFile.Dirty = true;
        }

        private void nudChild_ValueChanged(object sender, EventArgs e)
        {
            if (nudChild.Value != SelectedWopFile.Child)
                SelectedWopFile.Dirty = true;
        }

        private void nudParent_ValueChanged(object sender, EventArgs e)
        {
            if (nudParent.Value != SelectedWopFile.Parent)
                SelectedWopFile.Dirty = true;
        }

        private void nudCurrentAnim_ValueChanged(object sender, EventArgs e)
        {
            if (nudCurrentAnim.Value != SelectedWopFile.CurrentAnim)
                SelectedWopFile.Dirty = true;
        }

        private void nudStandardAnim_ValueChanged(object sender, EventArgs e)
        {
            if (nudStandardAnim.Value != SelectedWopFile.StandardAnim)
                SelectedWopFile.Dirty = true;
        }

        private void nudTileX_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileX.Value != SelectedWopFile.TileX)
                SelectedWopFile.Dirty = true;
        }

        private void nudTileY_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileY.Value != SelectedWopFile.TileY)
                SelectedWopFile.Dirty = true;
        }

        private void nudTileX2_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileX2.Value != SelectedWopFile.TileX2)
                SelectedWopFile.Dirty = true;
        }

        private void nudTileY2_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileY2.Value != SelectedWopFile.TileY2)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt8_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt8.Value != SelectedWopFile.FutureInt8)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt10_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt10.Value != SelectedWopFile.FutureInt10)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt11_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt11.Value != SelectedWopFile.FutureInt11)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt12_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt12.Value != SelectedWopFile.FutureInt12)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt13_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt13.Value != SelectedWopFile.FutureInt13)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt14_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt14.Value != SelectedWopFile.FutureInt14)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt15_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt15.Value != SelectedWopFile.FutureInt15)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt16_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt16.Value != SelectedWopFile.FutureInt16)
                SelectedWopFile.Dirty = true;
        }

        private void nudShadow_ValueChanged(object sender, EventArgs e)
        {
            if (nudShadow.Value != SelectedWopFile.Shadow)
                SelectedWopFile.Dirty = true;
        }

        private void nudLinked_ValueChanged(object sender, EventArgs e)
        {
            if (nudLinked.Value != SelectedWopFile.Linked)
                SelectedWopFile.Dirty = true;
        }

        private void nudLinkBack_ValueChanged(object sender, EventArgs e)
        {
            if (nudLinkBack.Value != SelectedWopFile.LinkBack)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt21_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt21.Value != SelectedWopFile.FutureInt21)
                SelectedWopFile.Dirty = true;
        }

        private void nudFrozen_ValueChanged(object sender, EventArgs e)
        {
            if (nudFrozen.Value != SelectedWopFile.Frozen)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt23_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt23.Value != SelectedWopFile.FutureInt23)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt24_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt24.Value != SelectedWopFile.FutureInt24)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureInt25_ValueChanged(object sender, EventArgs e)
        {
            if (nudFutureInt25.Value != SelectedWopFile.FutureInt25)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat2_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat2.Value - SelectedWopFile.FutureFloat2) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat3_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat3.Value - SelectedWopFile.FutureFloat3) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat4_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat4.Value - SelectedWopFile.FutureFloat4) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat5_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat5.Value - SelectedWopFile.FutureFloat5) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat6_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat6.Value - SelectedWopFile.FutureFloat6) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat7_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat7.Value - SelectedWopFile.FutureFloat7) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat8_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat8.Value - SelectedWopFile.FutureFloat8) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat9_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat9.Value - SelectedWopFile.FutureFloat9) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void nudFutureFloat10_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudFutureFloat10.Value - SelectedWopFile.FutureFloat10) > 0.01f)
                SelectedWopFile.Dirty = true;
        }

        private void txtFutureString1_TextChanged(object sender, EventArgs e)
        {
            if (txtFutureString1.Text != SelectedWopFile.FutureString1)
                SelectedWopFile.Dirty = true;
        }

        private void txtFutureString2_TextChanged(object sender, EventArgs e)
        {
            if (txtFutureString2.Text != SelectedWopFile.FutureString2)
                SelectedWopFile.Dirty = true;
        }
    }
}
