using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GetBoundry : MonoBehaviour
{
    public XRInputSubsystem xr = new UnityEngine.XR.XRInputSubsystem();
    public List<Vector3> boundryPoints = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            xr.TryGetBoundaryPoints(boundryPoints);
            xr.boundaryChanged += delegate (XRInputSubsystem i)
            {
                i.TryGetBoundaryPoints(boundryPoints);
            };//Hopefully I'll get updated boundry points now
        }
        catch { }

    }

    void Update()
    {
        try
        {
            SubsystemManager.GetAllSubsystemDescriptors(new List<ISubsystemDescriptor>());//<XRInputSubsystem>;

            xr.TryGetBoundaryPoints(boundryPoints);
            xr.boundaryChanged += delegate (XRInputSubsystem i)
            {
                i.TryGetBoundaryPoints(boundryPoints);
            };//Hopefully I'll get updated boundry points now
        }
        catch { }

    }

}
