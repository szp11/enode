﻿using System;
using BankTransferSample.Domain;
using ENode.Eventing;

namespace BankTransferSample.DomainEvents.Transaction
{
    /// <summary>交易已终止
    /// </summary>
    [Serializable]
    public class TransactionAborted : DomainEvent<Guid>, ISourcingEvent, ICompletionEvent
    {
        public TransactionInfo TransactionInfo { get; private set; }
        public DateTime AbortedTime { get; private set; }

        public TransactionAborted(Guid transactionId, TransactionInfo transactionInfo, DateTime abortedTime) : base(transactionId)
        {
            TransactionInfo = transactionInfo;
            AbortedTime = abortedTime;
        }
    }
}