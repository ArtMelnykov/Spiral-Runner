using UnityEngine;

namespace CodeBase.Infrastructure.Services.MovementService
{
    public interface IMovementService : IService
    {
        void Jump(Vector3 jumpDirection, float jumpForce);
    }
}