using ServiceStack.Redis;

namespace DockerDemo.Services
{
    public class RedisService
    {
        private readonly IRedisClient _client;

        public RedisService()
        {
            var manager = new RedisManagerPool("redis:6379");
            _client = manager.GetClient();
        }

        public void Set(string key, string value)
        {
            _client.Set(key, value);
        }

        public string Get(string key)
        {
            return _client.Get<string>(key);
        }
    }
}
