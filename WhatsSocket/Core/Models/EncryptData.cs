﻿namespace WhatsSocket.Core.Models
{
    public class EncryptData
    {
        public int Type { get; set; }
        public byte[] Data { get; set; }
    }


    public class CipherMessage
    {
        public string Type { get; set; }
        public byte[] CipherText { get; set; }
    }

}
