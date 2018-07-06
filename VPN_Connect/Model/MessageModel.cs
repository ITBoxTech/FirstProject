namespace VPN_Connect.Model
{
    class MessageModel
    {
        public string[,] InfoMsg = new string[,]
        {
                //Error
                {"1001", "Error: Please Input Correct Information."},
                {"1002", "Error: Exception while Create VPN Connection."},
                {"1003", "Error: Exception while connecting VPN."},
                {"1004", "Error: Please Check the Network Config Of Device."},
                {"1005", "Error: Login Failed."},

                //Information
                {"2001", "System: Create VPN Connection Complete."},
                {"2002", "System: Connection Success."},
                {"2003", "System: Connect Already Connected."},

                //Encryption
                {"3001", "checkipaddress"}
        };

        //MessageModal Constructor
        public MessageModel()
        {

        }
    }
}