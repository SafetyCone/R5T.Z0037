using System;
using System.Collections.Generic;
using System.Linq;

using R5T.F0000.ArrayExtensions;
using R5T.T0131;
using R5T.T0161.Extensions;
using R5T.T0169;
using R5T.T0171;


namespace R5T.Z0037
{
    [ValuesMarker]
    public partial interface IInstanceVarietyDescriptors : IValuesMarker
    {
        #region Static

        private static readonly Lazy<InstanceVarietyDescriptor[]> zAll = new Lazy<InstanceVarietyDescriptor[]>(() =>
        {
            var instance = InstanceVarietyDescriptors.Instance;

            var output = new[]
            {
                instance.Checks,
                instance.ConstantDrafts,
                instance.Constants,
                instance.ContextDefinitions,
                instance.ContextImplementations,
                instance.ContextOperations,
                instance.ContextTypeDrafts,
                instance.ContextTypes,
                instance.DataTypeDrafts,
                instance.DataTypes,
                instance.DemonstrationDrafts,
                instance.Demonstrations,
                instance.Documentation,
                instance.DocumentationDrafts,
                instance.Entities,
                instance.ExperimentDrafts,
                instance.Experiments,
                instance.ExplorationDrafts,
                instance.Explorations,
                instance.FunctionDrafts,
                instance.Functions,
                instance.HasXs,
                instance.MarkerDrafts,
                instance.Markers,
                instance.RazorComponentDrafts,
                instance.RazorComponents,
                instance.RazorLayouts,
                instance.RazorPages,
                instance.RepositoryDefinitions,
                instance.RepositoryImplementations,
                instance.Scripts,
                instance.ServiceDefinitionDrafts,
                instance.ServiceDefinitions,
                instance.ServiceImplementationDrafts,
                instance.ServiceImplementations,
                instance.StrongTypeDrafts,
                instance.StrongTypeImplementationDrafts,
                instance.StrongTypeImplementations,
                instance.StrongTypeInterfaceDrafts,
                instance.StrongTypeInterfaces,
                instance.StrongTypes,
                instance.TestArticleImplementations,
                instance.TestArticles,
                instance.TestFixtureImplementations,
                instance.TestFixtures,
                instance.TypeDrafts,
                instance.Types,
                instance.UtilityTypeDrafts,
                instance.UtilityTypes,
                instance.ValueDrafts,
                instance.Values,
                instance.WithXs
            };

            return output;
        });

        private static readonly Lazy<Dictionary<IInstanceVarietyName, InstanceVarietyDescriptor>> zAllByName = new Lazy<Dictionary<IInstanceVarietyName, InstanceVarietyDescriptor>>(() =>
        {
            var output = IInstanceVarietyDescriptors.zAll.Value.ToDictionary(
                x => x.Name);

            return output;
        });

        #endregion


        public Dictionary<IInstanceVarietyName, InstanceVarietyDescriptor> AllByName => IInstanceVarietyDescriptors.zAllByName.Value;


        public InstanceVarietyDescriptor Checks => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0244.CheckMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Checks,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Constants => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.ConstantsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Constants,
            Targets = InstanceVarietyTarget.PropertiesOfType.ToArray(),
        };

        public InstanceVarietyDescriptor ConstantDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.DraftConstantsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ConstantDrafts,
            Targets = InstanceVarietyTarget.PropertiesOfType.ToArray(),
        };

        public InstanceVarietyDescriptor ContextDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextDefinitions,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ContextImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ContextOperations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0241.ContextOperationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextOperations,
            // Same as values.
            Targets = new[]
            {
                InstanceVarietyTarget.MethodsAsProperties,
                InstanceVarietyTarget.PropertiesOfType,
            },
        };

        public InstanceVarietyDescriptor ContextTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextTypes,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ContextTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.DraftContextTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextTypeDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };


        public InstanceVarietyDescriptor DataTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DataTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DataTypes,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor DataTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftDataTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DataTypeDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor DbContextDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0250.DbContextDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DbContextDefinitions,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor DbContextImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0250.DbContextImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DbContextImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Demonstrations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DemonstrationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Demonstrations,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor Documentation => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0156.DocumentationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Documentation,
            Targets = InstanceVarietyTarget.StaticReadOnlyObjects.ToArray(),
        };

        public InstanceVarietyDescriptor DocumentationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0156.DraftDocumentationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DocumentationDrafts,
            Targets = InstanceVarietyTarget.StaticReadOnlyObjects.ToArray(),
        };

        public InstanceVarietyDescriptor DemonstrationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftDemonstrationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DemonstrationDrafts,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor Entities => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0249.EntityMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Entities,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Experiments => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.ExperimentsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Experiments,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor ExperimentDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftExperimentsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ExperimentDrafts,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor Explorations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.ExplorationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Explorations,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor ExplorationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftExplorationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ExplorationDrafts,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor Functions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0132.FunctionalityMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Functions,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor FunctionDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0132.DraftFunctionalityMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.FunctionDrafts,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor HasXs => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0240.HasXMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.HasXs,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Markers => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0143.MarkerAttributeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Markers,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor MarkerDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0143.DraftMarkerAttributeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.MarkerDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor PhysicalDbContextImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0250.PhysicalDbContextImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.PhysicalDbContextImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RazorComponents => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.RazorComponentMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorComponents,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RazorLayouts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.RazorLayoutMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorLayouts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RazorLinks => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0223.RazorLinkMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorLinks,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RazorPages => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.RazorPageMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorPages,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RazorComponentDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.DraftRazorComponentMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorComponentDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RepositoryDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0247.RepositoryDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RepositoryDefinitions,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor RepositoryImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0247.RepositoryImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RepositoryImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Scripts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0246.ScriptsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Scripts,
            Targets = InstanceVarietyTarget.MethodsOfType.ToArray(),
        };

        public InstanceVarietyDescriptor ServiceDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.ServiceDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceDefinitions,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ServiceDefinitionDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.DraftServiceDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceDefinitionDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ServiceImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.ServiceImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor ServiceImplementationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.DraftServiceImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceImplementationDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0150.StrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypes,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypeInterfaces => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0178.StrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeInterfaces,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypeInterfaceDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0178.DraftStrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeInterfaceDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypeImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0178.StrongTypeImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypeImplementationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0178.DraftStrongTypeImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeImplementationDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor StrongTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0150.DraftStrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Types => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.TypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Types,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor TestArticleImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0243.TestArticleImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TestArticleImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor TestArticles => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0243.TestArticleMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TestArticles,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor TestFixtureImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0243.TestFixtureImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TestFixtureImplementations,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor TestFixtures => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0243.TestFixtureMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TestFixtures,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor TypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TypeDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor UtilityTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.UtilityTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.UtilityTypes,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor UtilityTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftUtilityTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.UtilityTypeDrafts,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };

        public InstanceVarietyDescriptor Values => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.ValuesMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Values,
            Targets = new[]
            {
                InstanceVarietyTarget.MethodsAsProperties,
                InstanceVarietyTarget.PropertiesOfType,
            }
        };

        public InstanceVarietyDescriptor ValueDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.DraftValuesMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ValueDrafts,
            Targets = InstanceVarietyTarget.PropertiesOfType.ToArray(),
        };

        public InstanceVarietyDescriptor WithXs => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0240.WithXMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.WithXs,
            Targets = InstanceVarietyTarget.Type.ToArray(),
        };
    }
}
