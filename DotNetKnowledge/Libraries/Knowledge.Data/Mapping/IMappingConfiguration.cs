using Microsoft.EntityFrameworkCore;


namespace Knowledge.Data.Mapping
{
    /// <summary>
    /// 表示数据库上下文模型映射配置
    /// </summary>
    public partial interface IMappingConfiguration
    {
        /// <summary>
        /// 应用此映射配置
        /// </summary>
        /// <param name="modelBuilder">构建器用于构造数据库上下文的模型</param>
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
