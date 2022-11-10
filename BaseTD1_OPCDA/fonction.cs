private Array ToProperArray(object OPCReturn)
{     
    IList myilist = OPCReturn as IList;
    if (myilist!=null)
    {
        Type elttype = myilist.GetType().GetElementType();
        Array tab = Array.CreateInstance(elttype, myilist.Count);
        int i = 0;
        foreach(var name in myilist)
        {   
            tab.SetValue(name, i); i++;    
        }
        return tab;
     }
     else
     { 
        return null; 
     }
 } 
