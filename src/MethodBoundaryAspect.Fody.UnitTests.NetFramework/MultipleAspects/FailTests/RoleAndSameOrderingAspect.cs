using MethodBoundaryAspect.Fody.Attributes;

namespace MethodBoundaryAspect.Fody.UnitTests.NetFramework.MultipleAspects.FailTests
{
    [ProvideAspectRole(TestRoles.Third)]
    [AspectRoleDependency(AspectDependencyAction.Order, AspectDependencyPosition.Before, TestRoles.Third)]
    public class RoleAndSameOrderingAspect : OnMethodBoundaryAspect
    {
    }
}