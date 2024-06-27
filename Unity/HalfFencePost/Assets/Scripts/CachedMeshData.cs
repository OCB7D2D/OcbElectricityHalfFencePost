// Decompiled with JetBrains decompiler
// Type: CachedMeshData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null


using System;
using UnityEngine;

[Serializable]
public class CachedMeshData
{
  public string name;
  public int vertexCount;
  public int triCount;

  public bool ApproximatelyEquals(CachedMeshData other) => this.name.Equals(other.name) && Mathf.Abs(this.vertexCount - other.vertexCount) < 10 && Mathf.Abs(this.triCount - other.triCount) < 10;
}
