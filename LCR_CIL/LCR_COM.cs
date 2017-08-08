using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTD2XX_NET;

namespace LCR_CIL
{
    //public const uint MSM_SETUP_PRIMARY_TPE = 0x7 << 3;
    
    public class LCR_Com
    {
        const string LCR_DESCRIPTION = "LCR_LINK1";

        public enum WR_CMD
        {

        };

        #region CONSTANT_DEFINITIONS

        public const int  GET_MSM_SETUP =   0x01;
        public const int  SET_MSM_SETUP =   0x02;
        public const int  GET_MSM_PARAM =   0x03;
        public const int  GET_PRI_VALUE =   0x04;
        public const int  GET_SEC_VALUE =   0x05;
        public const int  GET_SORT_R =      0x06;
        public const int  SET_SORT_R =      0x07;
        public const int  GET_SORT_L =      0x08;
        public const int  SET_SORT_L =      0x09;
        public const int  GET_SORT_C =      0x0A;
        public const int  SET_SORT_C =      0x0B;
        public const int  GET_SYS_INFO =    0x0C;
        public const int  SET_SYS_INFO =    0x0D;
        public const int  GET_DEV_SN =      0x0E;
        public const int  GET_CALI =        0x0F;
        public const int  SET_CALI =        0x10;
        public const int  GET_MIN =         0x11;
        public const int  GET_MAX =         0x12;
        public const int  GET_AVR =         0x13;
        public const int  LCR_ACK =         0x20;
        public const int  LCR_ERR =         0x21;

        public const uint MSM_SETUP_MEASUREMENT_TYPE = 0x7;
        //------------------------------------------
        public const uint MSMS_MEASUREMENT_TYPE_LCR = 0x0;
        public const uint MSMS_MEASUREMENT_TYPE_ESR = 0x1;
        public const uint MSMS_MEASUREMENT_TYPE_DCR = 0x2;
        public const uint MSMS_MEASUREMENT_TYPE_DIODE = 0x3;
        public const uint MSMS_MEASUREMENT_TYPE_SORTING = 0x4;
        public const uint MSMS_MEASUREMENT_TYPE_RECORDING = 0x5;
        public const uint MSMS_MEASUREMENT_TYPE_CONTINUITY = 0x6;
        public const uint MSMS_MEASUREMENT_TYPE_DIODE_REV = 0x7;

        public const uint MSM_SETUP_PRIMARY_TYPE = 0x7 << 3;
        //------------------------------------------
        public const uint MSMS_PRIMARY_TYPE_AUTO = 0x0;
        public const uint MSMS_PRIMARY_TYPE_R = 0x1;
        public const uint MSMS_PRIMARY_TYPE_L = 0x2;
        public const uint MSMS_PRIMARY_TYPE_C = 0x3;
        public const uint MSMS_PRIMARY_TYPE_Z = 0x4;

        public const uint MSM_SETUP_CIRCUIT_SETTING = 0x3 << 6;
        //------------------------------------------
        public const uint MSMS_CIRCUIT_SETTING_AUTO = 0x0;
        public const uint MSMS_CIRCUIT_SETTING_SERIES = 0x1;
        public const uint MSMS_CIRCUIT_SETTING_PARALLEL = 0x2;

        public const uint MSM_SETUP_SECONDARY_SETTING = 0x1 << 8;
        //------------------------------------------
        public const uint MSMS_SECONDARY_TYPE_RS_RP = 0x0;
        public const uint MSMS_SECONDARY_TYPE_D_Q = 0x1;

        public const uint MSM_SETUP_TEST_FREQ = 0x7 << 9;
        //------------------------------------------
        public const uint MSMS_TEST_FREQ_AUTO = 0x0;
        public const uint MSMS_TEST_FREQ_100HZ = 0x1;
        public const uint MSMS_TEST_FREQ_120HZ = 0x2;
        public const uint MSMS_TEST_FREQ_1KHZ = 0x3;
        public const uint MSMS_TEST_FREQ_10KHZ = 0x4;
        public const uint MSMS_TEST_FREQ_100KHZ = 0x5;

        public const uint MSM_SETUP_TEST_VOLTAGE = 0x3 << 12;
        //------------------------------------------
        public const uint MSMS_TEST_VOLTAGE_1000MV = 0x0;
        public const uint MSMS_TEST_VOLTAGE_500MV = 0x1;
        public const uint MSMS_TEST_VOLTAGE_200MV = 0x2;

        public const uint MSM_SETUP_PHASE_ANGLE = 0x7 << 14;
        //------------------------------------------
        public const uint MSMS_PHASE_ANGLE_AUTO = 0x0;
        public const uint MSMS_PHASE_ANGLE_5 = 0x1;
        public const uint MSMS_PHASE_ANGLE_10 = 0x2;
        public const uint MSMS_PHASE_ANGLE_15 = 0x3;
        public const uint MSMS_PHASE_ANGLE_20 = 0x4;
        public const uint MSMS_PHASE_ANGLE_30 = 0x5;
        public const uint MSMS_PHASE_ANGLE_45 = 0x6;

        public const uint MSM_SETUP_TEST_SPEED = 0x7 << 17;
        //------------------------------------------
        public const uint MSMS_TEST_SPEED_AUTO = 0x0;
        public const uint MSMS_TEST_SPEED_500MS = 0x1;
        public const uint MSMS_TEST_SPEED_1S = 0x2;
        public const uint MSMS_TEST_SPEED_2S = 0x3;

        public const uint MSM_SETUP_TOLERANCE = 0x7 << 20;
        //------------------------------------------
        public const uint MSMS_TOLERANCE_0_5 = 0x0;
        public const uint MSMS_TOLERANCE_1 = 0x1;
        public const uint MSMS_TOLERANCE_5 = 0x2;
        public const uint MSMS_TOLERANCE_10 = 0x3;
        public const uint MSMS_TOLERANCE_20 = 0x4;
        public const uint MSMS_TOLERANCE_30 = 0x5;

        public const uint MSM_SETUP_CONTINUITY = 0x7 << 23;
        //------------------------------------------
        public const uint MSMS_CONTINUITY_TH_0_1 = 0x0;
        public const uint MSMS_CONTINUITY_TH_0_5 = 0x1;
        public const uint MSMS_CONTINUITY_TH_1 = 0x2;
        public const uint MSMS_CONTINUITY_TH_10 = 0x3;
        public const uint MSMS_CONTINUITY_TH_100 = 0x4;
        public const uint MSMS_CONTINUITY_TH_1K = 0x5;

        public const uint MSM_SETUP_STATE = 0x3 << 27;
        //------------------------------------------
        public const uint MSMS_STATE_CLEAR = 0x0;
        public const uint MSMS_STATE_START = 0x1;
        public const uint MSMS_STATE_UPDATE = 0x2;
        public const uint MSMS_STATE_UPST  = 0x3;

        public const uint MSM_SETUP_BUZZER = 0x1 << 29;
        //------------------------------------------
        public const uint MSMS_BUZ_OFF = 0x0;
        public const uint MSMS_BUZ_BEEP = 0x1;

        public const uint MSM_SETUP_DISPLAY = 0x1 << 30;
        //------------------------------------------
        public const uint MSMS_DISPLAY_ON = 0x0;
        public const uint MSMS_DISPLAY_OFF = 0x1;


        //implement separate ini
        //public const uint MSMS_SETUP_DEFAULT = MSMS_MEASUREMENT_TYPE_LCR +
        //    MSMS_PRIMARY_TYPE_L + MSMS_TEST_FREQ_AUTO + MSMS_TEST_VOLTAGE_1000MV +
        //    MSMS_PHASE_ANGLE_10 + MSMS_TEST_SPEED_1S + MSMS_TOLERANCE_10 + MSMS_CONTINUITY_TH_10;



        //Bitfield msm_setup_flags definition per NOTE2

        public const uint MSM_PARAM_MEASUREMENT_TYPE = 0x7;
        //------------------------------------------
        public const uint MSMP_MEASUREMENT_TYPE_LCR = 0x0;
        public const uint MSMP_MEASUREMENT_TYPE_ESR = 0x1;
        public const uint MSMP_MEASUREMENT_TYPE_DCR = 0x2;
        public const uint MSMP_MEASUREMENT_TYPE_DIODE = 0x3;
        public const uint MSMP_MEASUREMENT_TYPE_SORTING = 0x4;

        public const uint MSM_PARAMETER_PRIMARY_TYPE = 0x7 << 3;
        //------------------------------------------
        public const uint MSMP_PRIMARY_TYPE_R = 0x1;
        public const uint MSMP_PRIMARY_TYPE_L = 0x2;
        public const uint MSMP_PRIMARY_TYPE_C = 0x3;
        public const uint MSMP_PRIMARY_TYPE_Z = 0x4;

        public const uint MSM_PARAMETER_CIRCUIT_SETTING = 0x3 << 6;
        //------------------------------------------
        public const uint MSMP_CIRCUIT_SETTING_SERIES = 0x1;
        public const uint MSMP_CIRCUIT_SETTING_PARALLEL = 0x2;

        public const uint MSM_PARAMETER_SECONDARY_SETTING = 0x1 << 8;
        //------------------------------------------
        public const uint MSMP_SECONDARY_TYPE_RS_RP = 0x0;
        public const uint MSMP_SECONDARY_TYPE_D_Q = 0x1;


        public const uint MSM_PARAMETER_TEST_FREQ = 0x7 << 9;
        //------------------------------------------
        public const uint MSMP_TEST_FREQ_100HZ = 0x1;
        public const uint MSMP_TEST_FREQ_120HZ = 0x2;
        public const uint MSMP_TEST_FREQ_1KHZ = 0x3;
        public const uint MSMP_TEST_FREQ_10KHZ = 0x4;
        public const uint MSMP_TEST_FREQ_100KHZ = 0x5;

        public const uint MSM_PARAMETER_TEST_VOLTAGE = 0x3 << 12;
        //------------------------------------------
        public const uint MSMP_TEST_VOLTAGE_1000MV = 0x0;
        public const uint MSMP_TEST_VOLTAGE_500MV = 0x1;
        public const uint MSMP_TEST_VOLTAGE_200MV = 0x2;

        public const uint MSM_PARAMETER_PHASE_ANGLE = 0x7 << 14;
        //------------------------------------------
        public const uint MSMP_PHASE_ANGLE_5 = 0x1;
        public const uint MSMP_PHASE_ANGLE_10 = 0x2;
        public const uint MSMP_PHASE_ANGLE_15 = 0x3;
        public const uint MSMP_PHASE_ANGLE_20 = 0x4;
        public const uint MSMP_PHASE_ANGLE_30 = 0x5;
        public const uint MSMP_PHASE_ANGLE_45 = 0x6;

        public const uint MSM_PARAMETER_TEST_SPEED = 0x7 << 17;
        //------------------------------------------
        public const uint MSMP_TEST_SPEED_250MS = 0x1;
        public const uint MSMP_TEST_SPEED_500MS = 0x2;
        public const uint MSMP_TEST_SPEED_1S = 0x3;

        public const uint MSM_PARAMETER_TOLERANCE = 0x7 << 20;
        //------------------------------------------
        public const uint MSMP_TOLERANCE_0_5 = 0x0;
        public const uint MSMP_TOLERANCE_1 = 0x1;
        public const uint MSMP_TOLERANCE_5 = 0x2;
        public const uint MSMP_TOLERANCE_10 = 0x3;
        public const uint MSMP_TOLERANCE_20 = 0x4;
        public const uint MSMP_TOLERANCE_30 = 0x5;

        public const uint MSM_PARAMETER_DEVICE_STATUS = 0x7 << 23;
        //------------------------------------------
        public const uint MSMP_STATUS_CLEAR = 0x0;
        public const uint MSMP_STATUS_DATA_READY = 0x1;
        public const uint MSMP_STATUS_DEVICE_IDLE = 0x2;
        public const uint MSMP_STATUS_DEVICE_START = 0x4;
        //##########################################

        //#############################################
        //Bitfield sys_info_flags definition per NOTE3

        public const uint SYS_INFO_DISPLAY_MODE = 0x1;
        //------------------------------------------
        public const uint SYSI_DISPLAY_MODE_RHAND = 0x0;
        public const uint SYSI_DISPLAY_MODE_LHAND = 0x1;

        public const uint SYS_INFO_CONTRAST = 0xF << 1;
        //------------------------------------------
        public const uint SYSI_CONTRAST_10 = 0x1;
        public const uint SYSI_CONTRAST_20 = 0x2;
        public const uint SYSI_CONTRAST_30 = 0x3;
        public const uint SYSI_CONTRAST_40 = 0x4;
        public const uint SYSI_CONTRAST_50 = 0x5;
        public const uint SYSI_CONTRAST_60 = 0x6;
        public const uint SYSI_CONTRAST_70 = 0x7;
        public const uint SYSI_CONTRAST_80 = 0x8;
        public const uint SYSI_CONTRAST_90 = 0x9;
        public const uint SYSI_CONTRAST_100 = 0xA;


        public const uint SYS_INFO_SOUND = 0x1 << 5;
        //------------------------------------------
        public const uint SYSI_SOUND_OFF = 0x0;
        public const uint SYSI_SOUND_ON = 0x1;

        public const uint SYS_INFO_TIMEOUT = 0x7 << 6;
        //------------------------------------------
        public const uint SYSI_TIMEOUT_30S = 0x0;
        public const uint SYSI_TIMEOUT_1M = 0x1;
        public const uint SYSI_TIMEOUT_2M = 0x2;
        public const uint SYSI_TIMEOUT_4M = 0x3;
        public const uint SYSI_TIMEOUT_ALWAYS_ON = 0x4;

        public const uint SYS_INFO_HW_MAJ_V = 0x3 << 9;
        //------------------------------------------

        public const uint SYS_INFO_HW_MIN_V = 0x7 << 11;
        //------------------------------------------

        public const uint SYS_INFO_SW_MAJ_V = 0x7 << 14;
        //------------------------------------------

        public const uint SYS_INFO_SW_MIN_V = 0x1F << 17;
        //------------------------------------------

        public const uint SYS_INFO_BAT_LEVEL = 0xF << 22;
        //------------------------------------------

        public const uint SYS_INFO_BAT_CHARGING = 0x1 << 26;
        //------------------------------------------
        //------------------------------------------
        public const uint SYSI_STATUS_PAR_CHANGE = 0x1 << 30;

        //#############################################
        //Bitfield calibration_config_flags definition per NOTE4

        public const uint CAL_CONFIG_SELFCAL = 0xF << 0;
        //------------------------------------------
        public const uint CALCF_CLEAR = 0x0;
        public const uint CALCF_OPEN_TIPS = 0x1;
        public const uint CALCF_OPEN_START = 0x2;
        public const uint CALCF_OPEN_PASS = 0x3;
        public const uint CALCF_OPEN_FAIL = 0x4;
        public const uint CALCF_OPEN_RESET = 0x5;
        public const uint CALCF_SHORT_TIPS = 0x6;
        public const uint CALCF_SHORT_START = 0x7;
        public const uint CALCF_SHORT_PASS = 0x8;
        public const uint CALCF_SHORT_FAIL = 0x9;
        public const uint CALCF_SHORT_RESET = 0xA;
        //##########################################
        #endregion

        private const int COMS_IDLE = 0;
        private const int COMS_WAIT = 1;
        private const int COMS_MEASUREMENT = 2;
        private const int COMS_UPDATE_LCR = 3;
        private const int COMS_UPDATE_LCR_IF = 4;
        private const int COMS_GET_STAT = 5;
        private const int COMS_REFRESH = 6;
        private const int COMS_ERROR = 7;


        public const int MESUREMENT_FAIL = 0;
        public const int MESUREMENT_IDLE = 1;
        public const int MESUREMENT_READY = 2;


        private FTDI ftdi = new FTDI();
        private bool isOpen = false;
        private bool isConnected = false;
        private bool _enableTimerLoop = true;
        private int _com_ini_cnt;

        public LCR_Com()
        {
            _com_state = COMS_IDLE;
            _ini_device_count = 0;
            _num_retr = 8;
            _curr_retr = 0;
            _com_ini_cnt=0;
            msm_setup_flags = 0;
            msm_setup_flags_pr = msm_setup_flags;
            isOpen = false;
        }
        ~LCR_Com()
        {
            CloseCom();
        }

        private byte[] rx_buffer = new byte[16];
        private byte[] tx_buffer = new byte[16];
        private uint msm_setup_flags, msm_setup_flags_pr; //Bitfield for msm_setup_flags definition
        private uint msm_param_flags, msm_param_flags_pr; //Bitfield for msm_param_flags definition
        private uint sys_info_flags, sys_info_flags_pr;  //Bitfield for sys_info_flags definition
        private uint calibration_config_flags, calibration_config_flags_pr;  //Bitfield for calibration_config_flags definition
        private int _com_err_cnt=10;
        private float _primaryValue;
        private float _secondaryValue;
        private int _com_state;
        private uint _ini_device_count; //number of FTDI devices after establishing communication 
        private int _num_retr, _curr_retr; // number com attampts (_curr_retr) not to exseed _num_retr
        private int _check_con_retr = 0;
        private uint _sw_SN = 0;

        private float _forwardVoltage;
        private float _forwardCurrent;
        private float _reverseVoltage;
        private float _reverseCurrent;

        public float ForwardVoltage { get { return _forwardVoltage; } set { _forwardVoltage = value; } }
        public float ForwardCurrent { get { return _forwardCurrent; } set { _forwardCurrent = value; } }
        public float ReverseVoltage { get { return _reverseVoltage; } set { _reverseVoltage = value; } }
        public float ReverseCurrent { get { return _reverseCurrent; } set { _reverseCurrent = value; } }

        public uint ComDataUint { get { return BitConverter.ToUInt32(rx_buffer, 2); } set { byte[] b = BitConverter.GetBytes(value); b.CopyTo(tx_buffer, 2); } }
        public float ComDataFloat { get { return BitConverter.ToSingle(rx_buffer, 2); } set { byte[] b = BitConverter.GetBytes(value); b.CopyTo(tx_buffer, 2); } }
        public float PrimaryValue { get { return _primaryValue; } set { _primaryValue = value; } }
        public float SecondaryValue { get { return _secondaryValue; } set { _secondaryValue = value; } }

        private String _err_str="";
        public String ErrorString { get { return _err_str; } set { _err_str = value; } }

        public uint HardwareSN
        {
            get
            {
                return 100*GetSystemInformation(SYS_INFO_HW_MAJ_V) + GetSystemInformation(SYS_INFO_HW_MIN_V);
            }
        }
        public uint SoftwareSN
        {
            get
            {
                uint ret;
                ret = 100*GetSystemInformation(SYS_INFO_SW_MAJ_V) + GetSystemInformation(SYS_INFO_SW_MIN_V);
                sys_info_flags = sys_info_flags_pr;
                return ret;
            }
        }

        public bool ComerrCnt {
            get {
                if (_com_err_cnt < 10) return true;
                return false;
            }
            set {
                if (value == false && _com_err_cnt < 50) _com_err_cnt++;
                else if (_com_err_cnt > 0) _com_err_cnt--;
            }
        }

        public bool EnableTimerLoop { set { _enableTimerLoop = value; } }

        

        #region METHOD_DEFINITIONS

        public bool IniCom()
        {
            uint DeviceCount=0;
            String TempDevString = "";
            if (isOpen == true) return true;

            if (FTDI.FT_STATUS.FT_OK != ftdi.GetNumberOfDevices(ref DeviceCount)) return false;
            if (DeviceCount == 0) return false;

            FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[DeviceCount];

            // Pop;ate our device list
            if (FTDI.FT_STATUS.FT_OK != ftdi.GetDeviceList(ftdiDeviceList)) return false;

            for (UInt32 i = 0; i < DeviceCount; i++)
            {
                TempDevString = ftdiDeviceList[i].Description.ToString();
                if (TempDevString == "FT230X Basic UART")
                {
                    if (FTDI.FT_STATUS.FT_OK != ftdi.OpenByDescription(TempDevString)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.ResetDevice()) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.Purge(FTDI.FT_PURGE.FT_PURGE_RX | FTDI.FT_PURGE.FT_PURGE_TX)) return false;
                    //if (FTDI.FT_STATUS.FT_OK != ftdi.SetBaudRate(57600)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.SetBaudRate(115200)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.SetDataCharacteristics(FTDI.FT_DATA_BITS.FT_BITS_8, FTDI.FT_STOP_BITS.FT_STOP_BITS_1, FTDI.FT_PARITY.FT_PARITY_NONE)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.SetFlowControl(FTDI.FT_FLOW_CONTROL.FT_FLOW_NONE, 0, 0)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.SetRTS(true)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.SetDTR(true)) return false;
                    if (FTDI.FT_STATUS.FT_OK != ftdi.InTransferSize(64)) return false;
                    isOpen = true;
                    _com_err_cnt = 20;
                    _ini_device_count = DeviceCount;
                    _com_ini_cnt = 0;
                    return true;
                }
            }
            isOpen = false;
            return false;
        }

        public bool OpenCom()
        {
            int retr = 8;
            while (retr-->0)
            {
                if (IniCom() == true)
                {
                    System.Threading.Thread.Sleep(500);
                    UpdateLcrScreen();
                    System.Threading.Thread.Sleep(200);
                    UpdateLcrScreen();
                    return true;
                }
            }
            return false;
        }

        public bool CloseCom()
        {
            if (isOpen == false) return true;
            if (FTDI.FT_STATUS.FT_OK != ftdi.Close()) return false;
            isOpen = false;
            _com_state = COMS_IDLE;
            _ini_device_count = 0;
            return true;
        }

        private bool SendMessage(uint cmdToLCR, ref uint cmdFromLCR)
        {
            if (Message(cmdToLCR, ref cmdFromLCR) == true)
            {
                ComerrCnt = false;  return true;
            }
            else  ComerrCnt = true;
            return true;
        }

        private bool Message(uint cmdToLCR, ref uint cmdFromLCR)
        {
            uint i=0, b=0;
            uint crc = 0xA5;
            tx_buffer[0] = 8; tx_buffer[1] = (byte)cmdToLCR;
            for (i = 0; i < 6; i++) crc = crc ^ tx_buffer[i];
            tx_buffer[6] = (byte)(crc ^ 0xFF);
            tx_buffer[7] = (byte)crc;
            try
            {
                if (FTDI.FT_STATUS.FT_OK != ftdi.Purge(FTDI.FT_PURGE.FT_PURGE_RX | FTDI.FT_PURGE.FT_PURGE_TX)) return false;
                if (FTDI.FT_STATUS.FT_OK != ftdi.Write(tx_buffer, 8, ref b)) return false; 
                if (FTDI.FT_STATUS.FT_OK != ftdi.SetTimeouts(200, 0)) return false;
                if (FTDI.FT_STATUS.FT_OK != ftdi.Read(rx_buffer, 16, ref b)) return false;
                if (b < 16) return false;
                for (i = 0; i < 8; i++) rx_buffer[i] = rx_buffer[i + 8];
                crc = 0xA5;
                for (i = 0; i < 6; i++) crc = crc ^ (uint)rx_buffer[i];
                if (crc != rx_buffer[7]) return false;
                cmdFromLCR = (uint)rx_buffer[1];
            }
            catch
            {
                return false;
            }
            return true;
        }

         /************* Measurement setup related methods (read and write)************************/

        public bool WriteMeasurementSetupToLCR()
        {
            uint cmd_out = 0;
            int n_retry = 8;
            if (isOpen == false) return false;
            ComDataUint = msm_setup_flags;
            while (n_retry-- > 0)
            {
                if (SendMessage(SET_MSM_SETUP, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                    {
                        SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_CLEAR);
                         return true;
                   }
            }
            SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_CLEAR);
            return false;
        }

        public bool ReadMeasurementSetupFromLCR()
        {
            uint cmd_out = 0;
            int n_retry = 8;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_MSM_SETUP, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                    {
                        msm_setup_flags_pr = msm_setup_flags;
                        msm_setup_flags = ComDataUint;
                        return true;
                    }
            }
            return false;
        }

        public bool WaitMeasurementSetupClear(int tout)//uint msms_type, ref uint msms_value)
        {
            for(int i = 0; i < tout; i++)
            {
                if (ReadMeasurementSetupFromLCR() == true)
                {
                    if(GetMeasurementSetup(MSM_SETUP_STATE)== MSMS_STATE_CLEAR)
                    {
                        return true;
                    }
                }
                System.Threading.Thread.Sleep(10);
            }
            return false;
        }

        public bool IsMeasurementSetupChanged()
        {
            if(msm_setup_flags_pr != msm_setup_flags) return true;
            return false;
        }

        public void SetMeasurementSetup(uint type, uint value)
        {
            int sft = 0;
            uint max = 0;
            switch (type)
            {
                case MSM_SETUP_MEASUREMENT_TYPE: sft = 0; max = 7; break;
                case MSM_SETUP_PRIMARY_TYPE: sft = 3; max = 4; break;
                case MSM_SETUP_CIRCUIT_SETTING: sft = 6; max = 2; break;
                case MSM_SETUP_SECONDARY_SETTING: sft = 8; max = 1; break;
                case MSM_SETUP_TEST_FREQ: sft = 9; max = 5; break;
                case MSM_SETUP_TEST_VOLTAGE: sft = 12; max = 2; break;
                case MSM_SETUP_PHASE_ANGLE: sft = 14; max = 6; break;
                case MSM_SETUP_TEST_SPEED: sft = 17; max = 3; break;
                case MSM_SETUP_TOLERANCE: sft = 20; max = 5; break;
                case MSM_SETUP_CONTINUITY: sft = 23; max = 5; break;
                case MSM_SETUP_STATE: sft = 27; max = 2; break;
                case MSM_SETUP_BUZZER: sft = 29; max = 1; break;
                case MSM_SETUP_DISPLAY: sft = 30; max = 1; break;
                default: break;
            }
            if (value > max) value = max;
            msm_setup_flags_pr = msm_setup_flags;
            msm_setup_flags = msm_setup_flags & (0xFFFFFFFF ^ type);
            msm_setup_flags = msm_setup_flags | (type & (value<<sft));
        }

        public uint GetMeasurementSetup(uint type)
        {
            int sft = 0;
            uint max = 0;
            uint v = 0;
            switch (type)
            {
                case MSM_SETUP_MEASUREMENT_TYPE: sft = 0; max = 7; break;
                case MSM_SETUP_PRIMARY_TYPE: sft = 3; max = 4; break;
                case MSM_SETUP_CIRCUIT_SETTING: sft = 6; max = 2; break;
                case MSM_SETUP_SECONDARY_SETTING: sft = 8; max = 1; break;
                case MSM_SETUP_TEST_FREQ: sft = 9; max = 5; break;
                case MSM_SETUP_TEST_VOLTAGE: sft = 12; max = 2; break;
                case MSM_SETUP_PHASE_ANGLE: sft = 14; max = 6; break;
                case MSM_SETUP_TEST_SPEED: sft = 17; max = 3; break;
                case MSM_SETUP_TOLERANCE: sft = 20; max = 5; break;
                case MSM_SETUP_CONTINUITY: sft = 23; max = 5; break;
                case MSM_SETUP_STATE: sft = 27; max = 2; break;
                case MSM_SETUP_BUZZER: sft = 29; max = 1; break;
                case MSM_SETUP_DISPLAY: sft = 30; max = 1; break;
                default: break;
            }
            v = (msm_setup_flags & type) >> sft;
            if (v > max) v = max;

            return v;
        }

        /************* End of measurement setup related methods ************************/


        /************* Measurement parameters related methods (read only)************************/

        public bool ReadMeasurementParametersFromLCR()//uint msms_type, ref uint msms_value)
        {
            uint cmd_out = 0;
            int n_retry = 8;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_MSM_PARAM, ref cmd_out) == true) 
                    if (cmd_out == LCR_ACK)
                    {
                        msm_param_flags_pr = msm_param_flags;
                        msm_param_flags = ComDataUint;
                        return true;
                    }
            }
            return false;
        }

        public bool IsMeasurementParametersChanged()
        {
            if (msm_param_flags_pr != msm_param_flags) return true;
            return false;
        }

        public uint GetMeasurementParameter(uint type)
        {
            int sft = 0;
            uint max = 0;
            uint v = 0;
            switch (type)
            {
                case MSM_PARAM_MEASUREMENT_TYPE: sft = 0; max = 4; break;
                case MSM_PARAMETER_PRIMARY_TYPE: sft = 3; max = 4; break;
                case MSM_PARAMETER_CIRCUIT_SETTING: sft = 6; max = 1; break;
                case MSM_PARAMETER_SECONDARY_SETTING: sft = 8; max = 1; break;
                case MSM_PARAMETER_TEST_FREQ: sft = 9; max = 5; break;
                case MSM_PARAMETER_TEST_VOLTAGE: sft = 12; max = 2; break;
                case MSM_PARAMETER_PHASE_ANGLE: sft = 14; max = 5; break;
                case MSM_PARAMETER_TEST_SPEED: sft = 17; max = 2; break;
                case MSM_PARAMETER_TOLERANCE: sft = 20; max = 5; break;
                case MSM_PARAMETER_DEVICE_STATUS: sft = 23; max = 3; break;
                default: break;
            }
            v = (msm_param_flags & type) >> sft;
            if (v > max) v = max;

            return v;
        }

        /************* End of measurement setup related methods ************************/


        /************* System information related methods (read and write)************************/

        public bool WriteSysteminformationToLCR()
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = sys_info_flags;
            while (n_retry-- > 0)
            {
                if (SendMessage(SET_SYS_INFO, ref cmd_out) == true) 
                    if (cmd_out == LCR_ACK)
                        return true;
                //System.Threading.Thread.Sleep(100);
            }
            return false;
        }

        private bool sysinfoTimerFlag = false;

        public void SendSysteminformationToLCR()
        {
            sysinfoTimerFlag = true;
        }

        public bool ReadSysteminformationFromLCR()
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_SYS_INFO, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                    {
                        sys_info_flags_pr = sys_info_flags;
                        sys_info_flags = ComDataUint;
                        return true;
                    }
            }
            return false;
        }

        public void SetSystemInformation(uint type, uint value)
        {
            int sft = 0;
            uint max = 0;
            switch (type)
            {
                case SYS_INFO_DISPLAY_MODE: sft = 0; max = 1; break;
                case SYS_INFO_CONTRAST: sft = 1; max = 9; break;
                case SYS_INFO_SOUND: sft = 5; max = 1; break;
                case SYS_INFO_TIMEOUT: sft = 6; max = 4; break;
                case SYS_INFO_HW_MAJ_V: sft = 9; max = 3; break;
                case SYS_INFO_HW_MIN_V: sft = 11; max = 7; break;
                case SYS_INFO_SW_MAJ_V: sft = 14; max = 7; break;
                case SYS_INFO_SW_MIN_V: sft = 17; max = 31; break;
                case SYS_INFO_BAT_LEVEL: sft = 22; max = 15; break;
                case SYS_INFO_BAT_CHARGING: sft = 26; max = 1; break;
                case SYSI_STATUS_PAR_CHANGE: sft = 30; max = 2; break;
                default: break;
            }
            if (value > max) value = max;

            sys_info_flags = sys_info_flags & (0xFFFFFFFF ^ type);
            sys_info_flags = sys_info_flags | (type & (value << sft));
            if (IsSystemInformationChanged() == true && _enableTimerLoop)   SendSysteminformationToLCR();
        }

        public uint GetSystemInformation(uint type)
        {
            int sft = 0;
            uint max = 0;
            uint v = 0;
            switch (type)
            {
                case SYS_INFO_DISPLAY_MODE: sft = 0; max = 1; break;
                case SYS_INFO_CONTRAST: sft = 1; max = 9; break;
                case SYS_INFO_SOUND: sft = 5; max = 1; break;
                case SYS_INFO_TIMEOUT: sft = 6; max = 4; break;
                case SYS_INFO_HW_MAJ_V: sft = 9; max = 3; break;
                case SYS_INFO_HW_MIN_V: sft = 11; max = 7; break;
                case SYS_INFO_SW_MAJ_V: sft = 14; max = 7; break;
                case SYS_INFO_SW_MIN_V: sft = 17; max = 31; break;
                case SYS_INFO_BAT_LEVEL: sft = 22; max = 15; break;
                case SYS_INFO_BAT_CHARGING: sft = 26; max = 1; break;
                case SYSI_STATUS_PAR_CHANGE: sft = 30; max = 2; break;
                default: break;
            }
            v = (sys_info_flags & type) >> sft;
            if (v > max) v = max;

            return v;
        }

        public bool IsSystemInformationChanged()
        {
            if (sys_info_flags_pr != sys_info_flags) return true;
            return false;
        }

        /************* End of system information related methods ************************/


        /************* Calibration Config related methods (read and write)************************/

        public bool WriteCalibrationConfigToLCR()
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = calibration_config_flags;
            while (n_retry-- > 0)
            {
                if (SendMessage(SET_CALI, ref cmd_out) == true) 
                    if (cmd_out == LCR_ACK)
                        return true;
            }
            return false;
        }

        public bool ReadCalibrationConfigFromLCR()//uint msms_type, ref uint msms_value)
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_CALI, ref cmd_out) == true) 
                    if (cmd_out == LCR_ACK)
                    {
                        calibration_config_flags_pr = calibration_config_flags;
                        calibration_config_flags = ComDataUint;
                        return true;
                    }
            }
            return false;
        }

        public void SetCalibrationConfig(uint type, uint value)
        {
            calibration_config_flags_pr = calibration_config_flags;
            calibration_config_flags = calibration_config_flags & (0xFFFFFFFF ^ type);
            calibration_config_flags = calibration_config_flags | (type & value);
        }

        public uint GetCalibrationConfig(uint type)
        {
            return calibration_config_flags & type;
        }

        /************* End of CalibrationConfig related methods ************************/


        /*************** Sorting Values ************************************************/
        public bool WriteValueToLCR(uint sv_type, float sort_val)
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataFloat = sort_val;
            while (n_retry-- > 0)
            {
                if (SendMessage(sv_type, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                        return true;
            }
            return false;
        }
        /*******************************************************************************/

        public bool ReadPrimaryMeasurementValueFromLCR()//uint msms_type, ref uint msms_value)
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_PRI_VALUE, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                    {
                        _primaryValue = ComDataFloat;
                        return true;
                    }
            }
            return false;
        }

        public bool ReadSecondaryMeasurementValueFromLCR()//uint msms_type, ref uint msms_value)
        {
            uint cmd_out = 0;
            int n_retry = 4;
            if (isOpen == false) return false;
            ComDataUint = 0;
            while (n_retry-- > 0)
            {
                if (SendMessage(GET_SEC_VALUE, ref cmd_out) == true)
                    if (cmd_out == LCR_ACK)
                    {
                        _secondaryValue = ComDataFloat;
                        return true;
                    }
            }
            return false;
        }

        public bool UpdateLcrScreen()
        {
            SetMeasurementSetup(MSM_SETUP_STATE, MSMS_STATE_START);
            if (WriteMeasurementSetupToLCR() == false)
                if (WriteMeasurementSetupToLCR() == false) return false; 
            return true;
        }

        public int MakeMeasurement()
        {
            int rep = 200;
            uint a, b, c;
            bool ret;
            a = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long elapsedMs=0;
            //SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_UPST);
            SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_START);
            if (WriteMeasurementSetupToLCR() == true)
            {
                do
                {
                    ret = false;

                    if (_sw_SN == 214)
                    {
                        if (GetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE) == LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE)
                            System.Threading.Thread.Sleep(1000);
                        else
                            System.Threading.Thread.Sleep(750);
                        //if (ReadMeasurementSetupFromLCR() == true)
                        //    if (GetMeasurementSetup(LCR_Com.MSM_SETUP_STATE) == LCR_Com.MSMS_STATE_CLEAR)
                            ret = true;
                    }


                    if (ReadMeasurementParametersFromLCR() != true)
                    {
                        watch.Stop();
                        elapsedMs = watch.ElapsedMilliseconds;
                        _com_state = COMS_IDLE;
                        return MESUREMENT_FAIL;
                    }

                    a = GetMeasurementParameter(LCR_Com.MSM_PARAMETER_DEVICE_STATUS);
                    b = (uint)(LCR_Com.MSMP_STATUS_DATA_READY + LCR_Com.MSMP_STATUS_DEVICE_IDLE);
                    c = b & a;

                    if (c>0) ret = true;
                    System.Threading.Thread.Sleep(10);
                    rep--;
                }
                while (rep > 0 && (ret == false));

                if (ret == true)
                {
                    //check if it is an "IDLE" measurement - no measured component connected to LCR-Pro1
                    if (GetMeasurementParameter(LCR_Com.MSM_PARAMETER_DEVICE_STATUS) == LCR_Com.MSMP_STATUS_DEVICE_IDLE)
                    {
                        watch.Stop();
                        elapsedMs = watch.ElapsedMilliseconds;
                        //SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_UPDATE);
                        return MESUREMENT_IDLE;
                    }
                    //get primary value
                    if (ReadPrimaryMeasurementValueFromLCR() == true)
                    {
                        //get secondary value
                        if (ReadSecondaryMeasurementValueFromLCR() == true)
                        {
                            watch.Stop();
                            elapsedMs = watch.ElapsedMilliseconds;
                            return MESUREMENT_READY;
                        }
                    }
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            _com_state = COMS_IDLE;
            return MESUREMENT_FAIL;
        }

        public int MakeDiodeMeasurement()
        {
            if (MakeMeasurement() != MESUREMENT_READY)
            {
                SetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE, LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE);
                _com_state = COMS_IDLE;
                return MESUREMENT_FAIL;
            }
            _forwardVoltage =  PrimaryValue;
            _forwardCurrent = SecondaryValue;

            if (_sw_SN <= 112) return MESUREMENT_READY; 
            SetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE, LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE_REV);

            if (MakeMeasurement() != MESUREMENT_READY)
            {
                SetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE, LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE);
                _com_state = COMS_IDLE;
                return MESUREMENT_FAIL;
            }
            _reverseVoltage = PrimaryValue;
            _reverseCurrent = SecondaryValue;
            SetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE, LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE);
            return MESUREMENT_READY;
        }

        public int PingLcr()
        {
            if (ReadMeasurementParametersFromLCR()==true) // MeasurementSetupFromLCR() == true)
            {
                _check_con_retr = 0;
                _sw_SN = SoftwareSN;
                if (HardwareSN > 0 && HardwareSN < 500) ComerrCnt = false;
                if (isConnected == false) //has been disconected before
                {
                    if (ReadSysteminformationFromLCR() == true)
                    { 
                        _sw_SN = SoftwareSN;
                        isConnected = true;
                        return 0; //just re-connected       
                    }
                }
                WriteSysteminformationToLCR();
                // still connected
                return 1; // all OK
            }
            else // can't read sys info for some reason
            {
                isConnected = false; // set disconnected status
                _com_ini_cnt = 2;
                if (CheckConnection() == false)  //check connection and close port and call is fail, will try to re-open com  
                {
                    return 4; // - return code lost dongle connection
                }
                return 5; // - return code: lost LCR connection 
            }
            //return 0;
        }

        public bool CheckConnection()
        {
            uint DeviceCount = 0;
            _check_con_retr++;
            if(_check_con_retr>2)
            {
                if (IniCom() == true)
                {
                    WriteMeasurementSetupToLCR();
                    WriteSysteminformationToLCR();
                    return true;
                }
                return false;
     
            }
            if (FTDI.FT_STATUS.FT_OK != ftdi.GetNumberOfDevices(ref DeviceCount)) return false;
            if (DeviceCount != _ini_device_count)
            {
                CloseCom();
                isOpen = false;
                return false;
            }
            return true;
        }



        public int TimerLoop() //inser in timer handler with less than 500mS period
        {
            //EnableTimerLoop
            //int stt = -1;
            int res=-1;
            if (_enableTimerLoop == false)  return 0;

            //if (_com_ini_cnt > 0) // skip if timeout set
            //{
            //    _com_ini_cnt--;
            //    return 0;
            //}


            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //long elapsedMs = 0;

            //switch (PingLcr())
            //{
            //    case 0: //re-connected -> do measurement
            //        return 0;
            //        //if(_com_state == COMS_IDLE)
            //        //_com_state = COMS_MEASUREMENT;
            //        //break;
            //    case 1: //OK -> do measurement
            //        //if(_com_state == COMS_IDLE)
            //        _com_state = COMS_MEASUREMENT;
            //        break;
            //    case 4:
            //    case 5:
            //        _com_state = COMS_IDLE;
            //        return 5;
            //        //break;
            //    default: break;
            //}

            //watch.Stop();
            //elapsedMs = watch.ElapsedMilliseconds;


            if(sysinfoTimerFlag == true)
            {
                _com_state = COMS_UPDATE_LCR_IF;
                sysinfoTimerFlag = false;
            } 



            //if (isOpen == true)
            //{
            switch (_com_state)
                {
                    case COMS_WAIT: //do nothing in timer loop
                        _com_ini_cnt = 4;
                        return 0;
                    case COMS_IDLE: //checking for LCR-Pro1 response
                    _com_state = COMS_MEASUREMENT;
                    //HardwareSN = 0;

                    //if (ReadSysteminformationFromLCR() == true)
                    //{
                    //    _check_con_retr = 0;
                    //    _sw_SN = SoftwareSN;
                    //    if (HardwareSN > 0 && HardwareSN < 500) ComerrCnt = false;
                    //    if (isConnected == false)
                    //    {
                    //        if (ReadSysteminformationFromLCR() == true)
                    //        {
                    //            _sw_SN = SoftwareSN;
                    //            isConnected = true;
                    //        }

                    //    }
                    //    if (WriteMeasurementSetupToLCR() == true) _com_state = COMS_MEASUREMENT;
                    //}
                    //else
                    //{
                    //    isConnected = false;
                    //    _com_ini_cnt = 2;
                    //    if(CheckConnection()==false)  //IniCom();         //check connection and close port and call is fail, will try to re-open com  
                    //    {
                    //        return 4; // - return code lost dongle connection
                    //    }
                    //    return 5; // - return code: lost LCR connection 
                    //}
                    break;
                    case COMS_MEASUREMENT:
                        
                        if(GetMeasurementSetup(LCR_Com.MSM_SETUP_MEASUREMENT_TYPE) == LCR_Com.MSMS_MEASUREMENT_TYPE_DIODE)
                            res = MakeDiodeMeasurement();
                        else
                        {
                            res = MakeMeasurement();
                            //UpdateLcrScreen();
                        }
                        if (res == 0)
                        {
                            _com_state = COMS_ERROR;
                            return 5;
                        }
                        return res;
                    //if (_curr_retr < _num_retr)
                    //{
                    //    if (ReadMeasurementParametersFromLCR() == false) {
                    //        _com_state =COMS_IDLE;
                    //        return 5;
                    //    }
                    //    if (GetMeasurementParameter(LCR_Com.MSM_PARAMETER_DEVICE_STATUS) != LCR_Com.MSMP_STATUS_CLEAR)//ready new results
                    //    {
                    //        _curr_retr = 0;
                    //        if (GetMeasurementParameter(LCR_Com.MSM_PARAMETER_DEVICE_STATUS) == LCR_Com.MSMP_STATUS_DEVICE_IDLE)
                    //        {
                    //            SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_START); //will cause LCR screen to refresh
                    //            if (WriteMeasurementSetupToLCR() == false) { _com_state = COMS_IDLE; return 4; }   // send measurement setup data to LCR
                    //            return 6; //idle state
                    //        }

                    //        //retreve measured values
                    //        if (ReadPrimaryMeasurementValueFromLCR() == false) { _com_state = COMS_IDLE; return 4; }
                    //        if (ReadSecondaryMeasurementValueFromLCR() == false) { _com_state = COMS_IDLE; return 4; }

                    //        SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_START); //will cause LCR screen to refresh
                    //        if (WriteMeasurementSetupToLCR() == false)
                    //        {
                    //            _com_state = COMS_IDLE; return 4;
                    //        }   // send measurement setup data to LCR
                    //        //_com_ini_cnt = 2;
                    //        _check_con_retr = 0;
                    //        _com_state = COMS_MEASUREMENT;
                    //        return 7; //new measurement ready
                    //    }
                    //    _curr_retr++;
                    //    return 0; //keep checking
                    //}
                    //break;
                    case COMS_UPDATE_LCR:
                    //SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_UPDATE); //will cause LCR screen to refresh
                    //if (WriteMeasurementSetupToLCR() == false) { _com_ini_cnt = 2; return 4; }   // send measurement setup data to LCR
                    //if (UpdateLcrScreen() == false) { ErrorHandler(); break; }                 // send command to LCR to update sreen 
                    //_com_state = COMS_REFRESH;
                    _com_state = COMS_MEASUREMENT;// COMS_IDLE;
                        break;
                    case COMS_UPDATE_LCR_IF:
                        if (WriteSysteminformationToLCR() == false) { _com_ini_cnt = 2; _com_state = COMS_ERROR; return 4; }   // send measurement setup data to LCR
                        SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_UPDATE); //will cause LCR screen to refresh
                        if (WriteMeasurementSetupToLCR() == false) { _com_ini_cnt = 2; _com_state = COMS_ERROR; return 4; }   // send measurement setup data to LCR
                        if (UpdateLcrScreen() == false) { ErrorHandler(); break; }                 // send command to LCR to update sreen 
                    _com_state = COMS_MEASUREMENT;// COMS_IDLE;
                        break;
                    case COMS_GET_STAT:

                        break;
                    case COMS_ERROR:

                    switch (PingLcr())
                    {
                        case 0: //re-connected -> do measurement
                            _com_state = COMS_MEASUREMENT;
                            return 0;
                        //if(_com_state == COMS_IDLE)
                        //_com_state = COMS_MEASUREMENT;
                        //break;
                        case 1: //OK -> do measurement
                                //if(_com_state == COMS_IDLE)
                            _com_state = COMS_MEASUREMENT;
                            break;
                        case 4:
                        case 5:
                            //_com_state = COMS_IDLE;
                            //_com_state = COMS_MEASUREMENT;
                            return 5;
                        //break;
                        default: break;
                    }







                    _com_state = COMS_IDLE;
                        break;
                    case COMS_REFRESH:
                        SetMeasurementSetup(LCR_Com.MSM_SETUP_STATE, LCR_Com.MSMS_STATE_START); //will cause LCR screen to refresh
                        if (WriteMeasurementSetupToLCR() == false) { _com_ini_cnt = 2; return 4; }   // send measurement setup data to LCR
                        _com_state = COMS_IDLE;
                        break;
                    default: break;

                }
                return 1; // LCR is connected
            //}
            //else //try to connect or re-connect
            //{
            //     _com_ini_cnt = 2;
            //     if (IniCom() == true) return 2; // open or re-open com port
            //     else return 3;                  //open com port in progress
            //}
        }

        void ErrorHandler()
        {
            switch (_com_state)
            {
                case COMS_IDLE: ErrorString = "Communication Error ..."; _com_state = COMS_ERROR; break;
                case COMS_UPDATE_LCR: ErrorString = "Fail updating parameters"; _com_state = COMS_ERROR; break;
                //case COMS_START_MEASUREMENT: ErrorString = "Fail start measurement"; _com_state = COMS_ERROR; break;
                //case COMS_GET_MEAS_RESULT: ErrorString = "Fail read measurement"; _com_state = COMS_ERROR; break;
                default: ErrorString = "Unknown error ..."; _com_state = COMS_ERROR; break;
            }
            _curr_retr = 0;
        }

        #endregion
    }
}
