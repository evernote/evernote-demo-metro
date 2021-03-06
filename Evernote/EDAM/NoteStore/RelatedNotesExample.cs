/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.NoteStore
{

  #if !NETFX_CORE
  [Serializable]
  #endif
  public partial class RelatedNotesExample : TBase
  {
    private string _guid;
    private int _maxQueryTerms;
    private int _minTermFrequency;
    private double _scoreBoost;
    private RelatedNotesRequirement _requirement;

    public string Guid
    {
      get
      {
        return _guid;
      }
      set
      {
        __isset.guid = true;
        this._guid = value;
      }
    }

    public int MaxQueryTerms
    {
      get
      {
        return _maxQueryTerms;
      }
      set
      {
        __isset.maxQueryTerms = true;
        this._maxQueryTerms = value;
      }
    }

    public int MinTermFrequency
    {
      get
      {
        return _minTermFrequency;
      }
      set
      {
        __isset.minTermFrequency = true;
        this._minTermFrequency = value;
      }
    }

    public double ScoreBoost
    {
      get
      {
        return _scoreBoost;
      }
      set
      {
        __isset.scoreBoost = true;
        this._scoreBoost = value;
      }
    }

    public RelatedNotesRequirement Requirement
    {
      get
      {
        return _requirement;
      }
      set
      {
        __isset.requirement = true;
        this._requirement = value;
      }
    }


    public Isset __isset;
    #if !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool guid;
      public bool maxQueryTerms;
      public bool minTermFrequency;
      public bool scoreBoost;
      public bool requirement;
    }

    public RelatedNotesExample() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Guid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              MaxQueryTerms = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              MinTermFrequency = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Double) {
              ScoreBoost = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Requirement = (RelatedNotesRequirement)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RelatedNotesExample");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Guid != null && __isset.guid) {
        field.Name = "guid";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Guid);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxQueryTerms) {
        field.Name = "maxQueryTerms";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxQueryTerms);
        oprot.WriteFieldEnd();
      }
      if (__isset.minTermFrequency) {
        field.Name = "minTermFrequency";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MinTermFrequency);
        oprot.WriteFieldEnd();
      }
      if (__isset.scoreBoost) {
        field.Name = "scoreBoost";
        field.Type = TType.Double;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(ScoreBoost);
        oprot.WriteFieldEnd();
      }
      if (__isset.requirement) {
        field.Name = "requirement";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Requirement);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RelatedNotesExample(");
      sb.Append("Guid: ");
      sb.Append(Guid);
      sb.Append(",MaxQueryTerms: ");
      sb.Append(MaxQueryTerms);
      sb.Append(",MinTermFrequency: ");
      sb.Append(MinTermFrequency);
      sb.Append(",ScoreBoost: ");
      sb.Append(ScoreBoost);
      sb.Append(",Requirement: ");
      sb.Append(Requirement);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
