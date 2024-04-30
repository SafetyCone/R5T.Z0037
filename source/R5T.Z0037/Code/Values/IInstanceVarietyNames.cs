using System;

using R5T.T0131;
using R5T.T0171;
using R5T.T0171.Extensions;


namespace R5T.Z0037
{
    [ValuesMarker]
    public partial interface IInstanceVarietyNames : IValuesMarker
    {
        public IInstanceVarietyName Checks => "Checks".ToInstanceVarietyName();
        public IInstanceVarietyName Constants => "Constants".ToInstanceVarietyName();
        public IInstanceVarietyName ConstantDrafts => "Constant-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName ContextDefinitions => "ContextDefinitions".ToInstanceVarietyName();
        public IInstanceVarietyName ContextImplementations => "ContextImplementations".ToInstanceVarietyName();
        public IInstanceVarietyName ContextOperations => "ContextOperations".ToInstanceVarietyName();
        public IInstanceVarietyName ContextTypes => "ContextTypes".ToInstanceVarietyName();
        public IInstanceVarietyName ContextTypeDrafts => "ContextType-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName DataTypes => "DataTypes".ToInstanceVarietyName();
        public IInstanceVarietyName DataTypeDrafts => "DataType-Drafts".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>DbContext-Definitions</value></para>
        /// </summary>
        public IInstanceVarietyName DbContextDefinitions => "DbContext-Definitions".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>DbContext-Implementations</value></para>
        /// </summary>
        public IInstanceVarietyName DbContextImplementations => "DbContext-Implementations".ToInstanceVarietyName();

        public IInstanceVarietyName Demonstrations => "Demonstrations".ToInstanceVarietyName();
        public IInstanceVarietyName DemonstrationDrafts => "Demonstration-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName Documentation => "Documentation".ToInstanceVarietyName();
        public IInstanceVarietyName DocumentationDrafts => "Documentation-Drafts".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Entities</value></para>
        /// </summary>
        public IInstanceVarietyName Entities => "Entities".ToInstanceVarietyName();

        public IInstanceVarietyName Experiments => "Experiments".ToInstanceVarietyName();
        public IInstanceVarietyName ExperimentDrafts => "Experiment-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName Explorations => "Explorations".ToInstanceVarietyName();
        public IInstanceVarietyName ExplorationDrafts => "Exploration-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName Functions => "Functions".ToInstanceVarietyName();
        public IInstanceVarietyName FunctionDrafts => "Function-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName HasXs => "HasXs".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Markers</value></para>
        /// </summary>
        public IInstanceVarietyName Markers => "Markers".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>MarkerDrafts</value></para>
        /// </summary>
        public IInstanceVarietyName MarkerDrafts => "MarkerDrafts".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Physical-DbContext-Implementations</value></para>
        /// </summary>
        public IInstanceVarietyName PhysicalDbContextImplementations => "Physical-DbContext-Implementations".ToInstanceVarietyName();

        public IInstanceVarietyName RazorComponents => "RazorComponents".ToInstanceVarietyName();
        public IInstanceVarietyName RazorComponentDrafts => "RazorComponent-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName RazorLayouts => "RazorLayouts".ToInstanceVarietyName();
        public IInstanceVarietyName RazorLinks => "RazorLinks".ToInstanceVarietyName();
        public IInstanceVarietyName RazorPages => "RazorPages".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>RepositoryDefinitions</value></para>
        /// </summary>
        public IInstanceVarietyName RepositoryDefinitions => "RepositoryDefinitions".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>RepositoryImplementations</value></para>
        /// </summary>
        public IInstanceVarietyName RepositoryImplementations => "RepositoryImplementations".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Scripts</value></para>
        /// </summary>
        public IInstanceVarietyName Scripts => "Scripts".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>ServiceDefinitions</value></para>
        /// </summary>
        public IInstanceVarietyName ServiceDefinitions => "ServiceDefinitions".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>ServiceDefinitions-Drafts</value></para>
        /// </summary>
        public IInstanceVarietyName ServiceDefinitionDrafts => "ServiceDefinition-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName ServiceImplementations => "ServiceImplementations".ToInstanceVarietyName();
        public IInstanceVarietyName ServiceImplementationDrafts => "ServiceImplementation-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypes => "StrongTypes".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypeDrafts => "StrongType-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypeInterfaces => "StrongType-Interfaces".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypeInterfaceDrafts => "StrongType-Interface-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypeImplementations => "StrongType-Implementation".ToInstanceVarietyName();
        public IInstanceVarietyName StrongTypeImplementationDrafts => "StrongType-Implementation-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName TestArticleImplementations => "TestArticleImplementations".ToInstanceVarietyName();
        public IInstanceVarietyName TestArticles => "TestArticles".ToInstanceVarietyName();
        public IInstanceVarietyName TestFixtureImplementations => "TestFixtureImplementations".ToInstanceVarietyName();
        public IInstanceVarietyName TestFixtures => "TestFixtures".ToInstanceVarietyName();
        public IInstanceVarietyName Types => "Types".ToInstanceVarietyName();
        public IInstanceVarietyName TypeDrafts => "Type-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName UtilityTypes => "UtilityTypes".ToInstanceVarietyName();
        public IInstanceVarietyName UtilityTypeDrafts => "UtilityType-Drafts".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Values</value></para>
        /// </summary>
        public IInstanceVarietyName Values => "Values".ToInstanceVarietyName();

        /// <summary>
        /// <para><value>Value-Drafts</value></para>
        /// </summary>
        public IInstanceVarietyName ValueDrafts => "Value-Drafts".ToInstanceVarietyName();
        public IInstanceVarietyName WithXs => "WithXs".ToInstanceVarietyName();
    }
}
