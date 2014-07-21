namespace DesignPatterns.CreationalPatterns.ObjectPool.Pool
{
    public interface IObjectPool<T> where T : class
    {
        T Consume();
        void Release(T instance);
        int GetAmountOfConsumeableObjects();
    }
}