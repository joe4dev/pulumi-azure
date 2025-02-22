# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'ConfigurationFeatureTargetingFilterArgs',
    'ConfigurationFeatureTargetingFilterGroupArgs',
    'ConfigurationFeatureTimewindowFilterArgs',
    'ConfigurationStoreIdentityArgs',
    'ConfigurationStorePrimaryReadKeyArgs',
    'ConfigurationStorePrimaryWriteKeyArgs',
    'ConfigurationStoreSecondaryReadKeyArgs',
    'ConfigurationStoreSecondaryWriteKeyArgs',
]

@pulumi.input_type
class ConfigurationFeatureTargetingFilterArgs:
    def __init__(__self__, *,
                 default_rollout_percentage: pulumi.Input[int],
                 groups: Optional[pulumi.Input[Sequence[pulumi.Input['ConfigurationFeatureTargetingFilterGroupArgs']]]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        :param pulumi.Input[int] default_rollout_percentage: A number representing the percentage of the entire user base.
        :param pulumi.Input[Sequence[pulumi.Input['ConfigurationFeatureTargetingFilterGroupArgs']]] groups: One or more blocks of type `groups` as defined below.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] users: A list of users to target for this feature.
        """
        pulumi.set(__self__, "default_rollout_percentage", default_rollout_percentage)
        if groups is not None:
            pulumi.set(__self__, "groups", groups)
        if users is not None:
            pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter(name="defaultRolloutPercentage")
    def default_rollout_percentage(self) -> pulumi.Input[int]:
        """
        A number representing the percentage of the entire user base.
        """
        return pulumi.get(self, "default_rollout_percentage")

    @default_rollout_percentage.setter
    def default_rollout_percentage(self, value: pulumi.Input[int]):
        pulumi.set(self, "default_rollout_percentage", value)

    @property
    @pulumi.getter
    def groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ConfigurationFeatureTargetingFilterGroupArgs']]]]:
        """
        One or more blocks of type `groups` as defined below.
        """
        return pulumi.get(self, "groups")

    @groups.setter
    def groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ConfigurationFeatureTargetingFilterGroupArgs']]]]):
        pulumi.set(self, "groups", value)

    @property
    @pulumi.getter
    def users(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of users to target for this feature.
        """
        return pulumi.get(self, "users")

    @users.setter
    def users(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "users", value)


@pulumi.input_type
class ConfigurationFeatureTargetingFilterGroupArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 rollout_percentage: pulumi.Input[int]):
        """
        :param pulumi.Input[str] name: The name of the group.
        :param pulumi.Input[int] rollout_percentage: Rollout percentage of the group.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "rollout_percentage", rollout_percentage)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        The name of the group.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="rolloutPercentage")
    def rollout_percentage(self) -> pulumi.Input[int]:
        """
        Rollout percentage of the group.
        """
        return pulumi.get(self, "rollout_percentage")

    @rollout_percentage.setter
    def rollout_percentage(self, value: pulumi.Input[int]):
        pulumi.set(self, "rollout_percentage", value)


@pulumi.input_type
class ConfigurationFeatureTimewindowFilterArgs:
    def __init__(__self__, *,
                 end: Optional[pulumi.Input[str]] = None,
                 start: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] end: The latest timestamp the feature is enabled.  The timestamp must be in RFC3339 format.
        :param pulumi.Input[str] start: The earliest timestamp the feature is enabled. The timestamp must be in RFC3339 format.
        """
        if end is not None:
            pulumi.set(__self__, "end", end)
        if start is not None:
            pulumi.set(__self__, "start", start)

    @property
    @pulumi.getter
    def end(self) -> Optional[pulumi.Input[str]]:
        """
        The latest timestamp the feature is enabled.  The timestamp must be in RFC3339 format.
        """
        return pulumi.get(self, "end")

    @end.setter
    def end(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "end", value)

    @property
    @pulumi.getter
    def start(self) -> Optional[pulumi.Input[str]]:
        """
        The earliest timestamp the feature is enabled. The timestamp must be in RFC3339 format.
        """
        return pulumi.get(self, "start")

    @start.setter
    def start(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "start", value)


@pulumi.input_type
class ConfigurationStoreIdentityArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 identity_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 principal_id: Optional[pulumi.Input[str]] = None,
                 tenant_id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] type: Specifies the type of Managed Service Identity that should be configured on this App Configuration. Possible values are `SystemAssigned`, `UserAssigned`, `SystemAssigned, UserAssigned` (to enable both).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] identity_ids: A list of User Assigned Managed Identity IDs to be assigned to this App Configuration.
        :param pulumi.Input[str] principal_id: The Principal ID associated with this Managed Service Identity.
        :param pulumi.Input[str] tenant_id: The Tenant ID associated with this Managed Service Identity.
        """
        pulumi.set(__self__, "type", type)
        if identity_ids is not None:
            pulumi.set(__self__, "identity_ids", identity_ids)
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Specifies the type of Managed Service Identity that should be configured on this App Configuration. Possible values are `SystemAssigned`, `UserAssigned`, `SystemAssigned, UserAssigned` (to enable both).
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="identityIds")
    def identity_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of User Assigned Managed Identity IDs to be assigned to this App Configuration.
        """
        return pulumi.get(self, "identity_ids")

    @identity_ids.setter
    def identity_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "identity_ids", value)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Principal ID associated with this Managed Service Identity.
        """
        return pulumi.get(self, "principal_id")

    @principal_id.setter
    def principal_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "principal_id", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Tenant ID associated with this Managed Service Identity.
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tenant_id", value)


@pulumi.input_type
class ConfigurationStorePrimaryReadKeyArgs:
    def __init__(__self__, *,
                 connection_string: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] connection_string: The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        :param pulumi.Input[str] id: The ID of the Access Key.
        :param pulumi.Input[str] secret: The Secret of the Access Key.
        """
        if connection_string is not None:
            pulumi.set(__self__, "connection_string", connection_string)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)

    @property
    @pulumi.getter(name="connectionString")
    def connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        """
        return pulumi.get(self, "connection_string")

    @connection_string.setter
    def connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Access Key.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def secret(self) -> Optional[pulumi.Input[str]]:
        """
        The Secret of the Access Key.
        """
        return pulumi.get(self, "secret")

    @secret.setter
    def secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret", value)


@pulumi.input_type
class ConfigurationStorePrimaryWriteKeyArgs:
    def __init__(__self__, *,
                 connection_string: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] connection_string: The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        :param pulumi.Input[str] id: The ID of the Access Key.
        :param pulumi.Input[str] secret: The Secret of the Access Key.
        """
        if connection_string is not None:
            pulumi.set(__self__, "connection_string", connection_string)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)

    @property
    @pulumi.getter(name="connectionString")
    def connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        """
        return pulumi.get(self, "connection_string")

    @connection_string.setter
    def connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Access Key.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def secret(self) -> Optional[pulumi.Input[str]]:
        """
        The Secret of the Access Key.
        """
        return pulumi.get(self, "secret")

    @secret.setter
    def secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret", value)


@pulumi.input_type
class ConfigurationStoreSecondaryReadKeyArgs:
    def __init__(__self__, *,
                 connection_string: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] connection_string: The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        :param pulumi.Input[str] id: The ID of the Access Key.
        :param pulumi.Input[str] secret: The Secret of the Access Key.
        """
        if connection_string is not None:
            pulumi.set(__self__, "connection_string", connection_string)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)

    @property
    @pulumi.getter(name="connectionString")
    def connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        """
        return pulumi.get(self, "connection_string")

    @connection_string.setter
    def connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Access Key.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def secret(self) -> Optional[pulumi.Input[str]]:
        """
        The Secret of the Access Key.
        """
        return pulumi.get(self, "secret")

    @secret.setter
    def secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret", value)


@pulumi.input_type
class ConfigurationStoreSecondaryWriteKeyArgs:
    def __init__(__self__, *,
                 connection_string: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] connection_string: The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        :param pulumi.Input[str] id: The ID of the Access Key.
        :param pulumi.Input[str] secret: The Secret of the Access Key.
        """
        if connection_string is not None:
            pulumi.set(__self__, "connection_string", connection_string)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)

    @property
    @pulumi.getter(name="connectionString")
    def connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        The Connection String for this Access Key - comprising of the Endpoint, ID and Secret.
        """
        return pulumi.get(self, "connection_string")

    @connection_string.setter
    def connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Access Key.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def secret(self) -> Optional[pulumi.Input[str]]:
        """
        The Secret of the Access Key.
        """
        return pulumi.get(self, "secret")

    @secret.setter
    def secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret", value)


