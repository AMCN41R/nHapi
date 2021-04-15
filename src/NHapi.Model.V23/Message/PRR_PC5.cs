using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V23.Group;
using NHapi.Model.V23.Segment;
using NHapi.Model.V23.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V23.Message

{
///<summary>
/// Represents a PRR_PC5 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message header segment) </li>
///<li>1: MSA (Message acknowledgement segment) </li>
///<li>2: ERR (Error segment) optional </li>
///<li>3: QRD (Query definition segment) </li>
///<li>4: PRR_PC5_PATIENT (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class PRR_PC5 : AbstractMessage  {

	///<summary> 
	/// Creates a new PRR_PC5 Group with custom IModelClassFactory.
	///</summary>
	public PRR_PC5(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new PRR_PC5 Group with DefaultModelClassFactory. 
	///</summary> 
	public PRR_PC5() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for PRR_PC5.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(PRR_PC5_PATIENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PRR_PC5 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message header segment) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MSA (Message acknowledgement segment) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ERR (Error segment) - creates it if necessary
	///</summary>
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.GetStructure("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRD (Query definition segment) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of PRR_PC5_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public PRR_PC5_PATIENT GetPATIENT() {
	   PRR_PC5_PATIENT ret = null;
	   try {
	      ret = (PRR_PC5_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PRR_PC5_PATIENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PRR_PC5_PATIENT GetPATIENT(int rep) { 
	   return (PRR_PC5_PATIENT)this.GetStructure("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRR_PC5_PATIENT 
	 */ 
	public int PATIENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PRR_PC5_PATIENT results 
	 */ 
	public IEnumerable<PRR_PC5_PATIENT> PATIENTs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENTRepetitionsUsed; rep++)
			{
				yield return (PRR_PC5_PATIENT)this.GetStructure("PATIENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new PRR_PC5_PATIENT
	///</summary>
	public PRR_PC5_PATIENT AddPATIENT()
	{
		return this.AddStructure("PATIENT") as PRR_PC5_PATIENT;
	}

	///<summary>
	///Removes the given PRR_PC5_PATIENT
	///</summary>
	public void RemovePATIENT(PRR_PC5_PATIENT toRemove)
	{
		this.RemoveStructure("PATIENT", toRemove);
	}

	///<summary>
	///Removes the PRR_PC5_PATIENT at the given index
	///</summary>
	public void RemovePATIENTAt(int index)
	{
		this.RemoveRepetition("PATIENT", index);
	}

}
}
