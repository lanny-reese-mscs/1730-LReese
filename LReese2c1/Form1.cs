using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReese2c1
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        public Form1()
        {
            InitializeComponent();
        }

        private void setminbtn_Click(object sender, EventArgs e)
        {
            byte1 = byte.MinValue;      byte1Textbox.Text = byte1.ToString();
            
            sbyte1 = sbyte.MinValue;   sbyte1textbox.Text = sbyte1.ToString();
            
            short1 = short.MinValue; short1textbox.Text = short1.ToString();
            
            ushort1 = ushort.MinValue; ushort1textbox.Text = ushort1.ToString();
            
            int1 = int.MinValue; int1textbox.Text = int1.ToString();
            
            uint1 = uint.MinValue; uint1textbox.Text = uint1.ToString();
            
            long1 = long.MinValue; long1textbox.Text = long1.ToString();
            
            ulong1 = ulong.MinValue; ulong1textbox.Text = ulong1.ToString();
            
            float1 = float.MinValue; float1textbox.Text = float1.ToString();
            
            double1 = double.MinValue; double1textbox.Text = double1.ToString();
            
            decimal1 = decimal.MinValue; decimal1textbox.Text = decimal1.ToString();
        }

        private void setmaxbtn_Click(object sender, EventArgs e)
        {
            byte2 = byte.MaxValue; byte2textbox.Text = byte2.ToString();
            
            sbyte2 = sbyte.MaxValue; sbyte2textbox.Text = sbyte2.ToString();
            
            short2 = short.MaxValue; short2textbox.Text = short2.ToString();
            
            ushort2 = ushort.MaxValue; ushort2textbox.Text = ushort2.ToString();
            
            int2 = int.MaxValue; int2textbox.Text = int2.ToString();
            
            uint2 = uint.MaxValue; uint2textbox.Text = uint2.ToString();
            
            long2 = long.MaxValue; long2textbox.Text = long2.ToString();
            
            ulong2 = ulong.MaxValue; ulong2textbox.Text = ulong2.ToString();
            
            float2 = float.MaxValue; float2textbox.Text = float2.ToString();
            
            double2 = double.MaxValue; double2textbox.Text = double2.ToString();
            
            decimal2 = decimal.MaxValue; decimal2textbox.Text = decimal2.ToString();
        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                byte1 = Convert.ToByte(input1TextBox.Text);
                byte1Textbox.Text = byte1.ToString();
            }
            catch (Exception) { byte1Textbox.Text = "error"; byte1 = 0; }
            try
            {

                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyte1textbox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyte1textbox.Text = "error"; sbyte1 = 0; }

            try
            {

                short1 = Convert.ToInt16(input1TextBox.Text);
                short1textbox.Text = short1.ToString();
            }
            catch (Exception) { short1textbox.Text = "error"; short1 = 0; }

            try
            {

                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushort1textbox.Text = ushort1.ToString();
            }
            catch (Exception) { ushort1textbox.Text = "error"; ushort1 = 0; }

            try
            {

                int1 = Convert.ToInt32(input1TextBox.Text);
                int1textbox.Text = int1.ToString();
            }
            catch (Exception) { int1textbox.Text = "error"; int1 = 0; }

            try
            {

                uint1 = Convert.ToUInt32(input1TextBox.Text);
                uint1textbox.Text = uint1.ToString();
            }
            catch (Exception) { uint1textbox.Text = "error"; uint1 = 0; }

            try
            {

                long1 = Convert.ToInt64(input1TextBox.Text);
                long1textbox.Text = long1.ToString();
            }
            catch (Exception) { long1textbox.Text = "error"; long1 = 0; }

            try
            {

                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulong1textbox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1textbox.Text = "error"; ulong1 = 0; }

            try
            {

                float1 = Convert.ToSingle(input1TextBox.Text);
                float1textbox.Text = float1.ToString();
            }
            catch (Exception) { float1textbox.Text = "error"; float1 = 0.0f; }

            try
            {

                double1 = Convert.ToDouble(input1TextBox.Text);
                double1textbox.Text = double1.ToString();
            }
            catch (Exception) { double1textbox.Text = "error"; double1 = 0.0; }

            try
            {

                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimal1textbox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1textbox.Text = "error"; decimal1 = 0m; }
        }

        private void input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                byte2 = Convert.ToByte(input2TextBox.Text);
                byte2textbox.Text = byte2.ToString();
            }
            catch (Exception) { byte2textbox.Text = "error"; byte2 = 0; }
            try
            {

                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyte2textbox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2textbox.Text = "error"; sbyte2 = 0; }

            try
            {

                short2 = Convert.ToInt16(input2TextBox.Text);
                short2textbox.Text = short2.ToString();
            }
            catch (Exception) { short2textbox.Text = "error"; short2 = 0; }

            try
            {

                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushort2textbox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2textbox.Text = "error"; ushort2 = 0; }

            try
            {

                int2 = Convert.ToInt32(input2TextBox.Text);
                int2textbox.Text = int2.ToString();
            }
            catch (Exception) { int2textbox.Text = "error"; int2 = 0; }

            try
            {

                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uint2textbox.Text = uint2.ToString();
            }
            catch (Exception) { uint2textbox.Text = "error"; uint2 = 0; }

            try
            {

                long2 = Convert.ToInt64(input2TextBox.Text);
                long2textbox.Text = long2.ToString();
            }
            catch (Exception) { long2textbox.Text = "error"; long2 = 0; }

            try
            {

                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulong2textbox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2textbox.Text = "error"; ulong2 = 0; }

            try
            {

                float2 = Convert.ToSingle(input2TextBox.Text);
                float2textbox.Text = float2.ToString();
            }
            catch (Exception) { float2textbox.Text = "error"; float2 = 0.0f; }

            try
            {

                double2 = Convert.ToDouble(input2TextBox.Text);
                double2textbox.Text = double2.ToString();
            }
            catch (Exception) { double2textbox.Text = "error"; double2 = 0.0; }

            try
            {

                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimal2textbox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2textbox.Text = "error"; decimal2 = 0m; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "error";}

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
               ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 + this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 + this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 + this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 + this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 - this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 - this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 - this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 - this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; }
        }
        private void btntimes_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 * this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 * this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 * this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 * this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; }
        }
        private void btndevide_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 / this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 / this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 / this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 / this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; }
        }

    }
}
