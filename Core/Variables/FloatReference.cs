﻿using System;

[Serializable]
public class FloatReference
{
  public bool UseConstant = true;
  public float ConstantValue;
  public FloatVariable Variable;

  public FloatReference() { }

  public FloatReference(float value)
  {
    UseConstant = true;
    ConstantValue = value;
  }

  public float Value
  {
    get { return UseConstant ? ConstantValue : Variable.currentValue; }
  }

  public static implicit operator float(FloatReference reference)
  {
    return reference.Value;
  }
}