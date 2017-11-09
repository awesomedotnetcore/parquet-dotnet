﻿using Parquet.Data;

namespace Parquet.DataTypes
{
   class Int32DataType : BasicDataType<int>
   {
      public Int32DataType() : base(Thrift.Type.INT32, null, 32)
      {
      }

      protected override SchemaElement2 CreateSimple(SchemaElement2 parent, Thrift.SchemaElement tse)
      {
         return new SchemaElement2(tse.Name, DataType.Int32, parent);
      }
   }
}