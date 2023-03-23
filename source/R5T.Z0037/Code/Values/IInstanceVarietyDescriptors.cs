using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0131;
using R5T.T0161.Extensions;
using R5T.T0169;
using R5T.T0171;
using R5T.T0171.Extensions;


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
                instance.ConstantDrafts,
                instance.Constants,
                instance.ContextDefinitions,
                instance.ContextImplementations,
                instance.ContextTypeDrafts,
                instance.ContextTypes,
                instance.DataTypeDrafts,
                instance.DataTypes,
                instance.DemonstrationDrafts,
                instance.Demonstrations,
                instance.ExperimentDrafts,
                instance.Experiments,
                instance.ExplorationDrafts,
                instance.Explorations,
                instance.FunctionDrafts,
                instance.Functions,
                instance.MarkerDrafts,
                instance.Markers,
                instance.RazorComponentDrafts,
                instance.RazorComponents,
                instance.ServiceDefinitionDrafts,
                instance.ServiceDefinitions,
                instance.ServiceImplementationDrafts,
                instance.ServiceImplementations,
                instance.StrongTypeDrafts,
                instance.StrongTypes,
                instance.TypeDrafts,
                instance.Types,
                instance.UtilityTypeDrafts,
                instance.UtilityTypes,
                instance.ValueDrafts,
                instance.Values,
            };

            return output;
        });

        private static readonly Lazy<Dictionary<InstanceVarietyName, InstanceVarietyDescriptor>> zAllByName = new Lazy<Dictionary<InstanceVarietyName, InstanceVarietyDescriptor>>(() =>
        {
            var output = IInstanceVarietyDescriptors.zAll.Value.ToDictionary(
                x => x.Name);

            return output;
        });

        #endregion


        public Dictionary<InstanceVarietyName, InstanceVarietyDescriptor> AllByName => IInstanceVarietyDescriptors.zAllByName.Value;


        public InstanceVarietyDescriptor Constants => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.ConstantsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Constants,
            Target = InstanceVarietyTarget.PropertiesOfType,
        };

        public InstanceVarietyDescriptor ConstantDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.DraftConstantsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ConstantDrafts,
            Target = InstanceVarietyTarget.PropertiesOfType,
        };

        public InstanceVarietyDescriptor ContextDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextDefinitions,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ContextImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextImplementations,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ContextTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.ContextTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextTypes,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ContextTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0137.DraftContextTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ContextTypeDrafts,
            Target = InstanceVarietyTarget.Type,
        };


        public InstanceVarietyDescriptor DataTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DataTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DataTypes,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor DataTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftDataTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DataTypeDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor Demonstrations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DemonstrationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Demonstrations,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor DemonstrationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftDemonstrationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.DemonstrationDrafts,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor Experiments => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.ExperimentsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Experiments,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor ExperimentDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftExperimentsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ExperimentDrafts,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor Explorations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.ExplorationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Explorations,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor ExplorationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0141.DraftExplorationsMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ExplorationDrafts,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor Functions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0132.FunctionalityMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Functions,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor FunctionDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0132.DraftFunctionalityMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.FunctionDrafts,
            Target = InstanceVarietyTarget.MethodsOfType,
        };

        public InstanceVarietyDescriptor Markers => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0143.MarkerAttributeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Markers,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor MarkerDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0143.DraftMarkerAttributeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.MarkerDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor RazorComponents => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.RazorComponentMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorComponents,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor RazorComponentDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0154.DraftRazorComponentMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.RazorComponentDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ServiceDefinitions => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.ServiceDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceDefinitions,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ServiceDefinitionDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.DraftServiceDefinitionMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceDefinitionDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ServiceImplementations => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.ServiceImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceImplementations,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor ServiceImplementationDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0064.DraftServiceImplementationMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ServiceImplementationDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor StrongTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0150.StrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypes,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor StrongTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0150.DraftStrongTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.StrongTypeDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor Types => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.TypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Types,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor TypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.TypeDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor UtilityTypes => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.UtilityTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.UtilityTypes,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor UtilityTypeDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0142.DraftUtilityTypeMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.UtilityTypeDrafts,
            Target = InstanceVarietyTarget.Type,
        };

        public InstanceVarietyDescriptor Values => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.ValuesMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.Values,
            Target = InstanceVarietyTarget.PropertiesOfType,
        };

        public InstanceVarietyDescriptor ValueDrafts => new InstanceVarietyDescriptor
        {
            MarkerAttributeTypeName = "R5T.T0131.DraftValuesMarkerAttribute".ToAttributeTypeName(),
            Name = Instances.InstanceVarietyNames.ValueDrafts,
            Target = InstanceVarietyTarget.PropertiesOfType,
        };
    }
}
