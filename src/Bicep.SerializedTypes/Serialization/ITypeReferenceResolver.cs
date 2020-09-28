﻿using Bicep.SerializedTypes.Concrete;

namespace Bicep.SerializedTypes.Serialization
{
    public interface ITypeReferenceResolver
    {
        int GetIndex(TypeBase type);

        ITypeReference GetTypeReference(int index);
    }
}