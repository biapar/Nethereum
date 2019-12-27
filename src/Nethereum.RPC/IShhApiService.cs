﻿using Nethereum.RPC.Shh;

namespace Nethereum.RPC
{
    public interface IShhApiService
    {
        IShhKeyPair KeyPair { get; } 
        IShhSymKey SymKey { get; } 
        IShhMessageFilter MessageFilter { get; } 
        IShhVersion Version { get; }
    }
}