﻿using Nethereum.Wallet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;

namespace Nethereum.UI.Droid.Services
{
    public class WalletConfigurationService : IWalletConfigurationService
    {

        public WalletConfigurationService()
        {
            this.ClientUrl = "http://192.168.2.22:8545";
            this.Client = new RpcClient(new Uri(ClientUrl));
        }

        private IClient client;
        public IClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public string ClientUrl { get; set; }

        public bool IsConfigured()
        {
            //Todo get info from storage
            return true;
        }
    }
}
