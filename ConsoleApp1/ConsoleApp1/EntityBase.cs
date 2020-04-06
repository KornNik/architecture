﻿using System;

namespace Task1
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public EntityBase(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }
}