using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Storage.Model {
  public class StorageExistResponse {
    public bool IsExist { get; set; }

    public string Code { get; set; }

    public string Status { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StorageExistResponse {\n");
      sb.Append("  IsExist: ").Append(IsExist).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
