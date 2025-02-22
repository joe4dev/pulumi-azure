# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['LiveEventOutputArgs', 'LiveEventOutput']

@pulumi.input_type
class LiveEventOutputArgs:
    def __init__(__self__, *,
                 archive_window_duration: pulumi.Input[str],
                 asset_name: pulumi.Input[str],
                 live_event_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 hls_fragments_per_ts_segment: Optional[pulumi.Input[int]] = None,
                 manifest_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 output_snap_time_in_seconds: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a LiveEventOutput resource.
        :param pulumi.Input[str] archive_window_duration: `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] asset_name: The asset that the live output will write to. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] live_event_id: The id of the live event. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] description: The description of the live output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[int] hls_fragments_per_ts_segment: The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] manifest_name: The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] name: The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        pulumi.set(__self__, "archive_window_duration", archive_window_duration)
        pulumi.set(__self__, "asset_name", asset_name)
        pulumi.set(__self__, "live_event_id", live_event_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if hls_fragments_per_ts_segment is not None:
            pulumi.set(__self__, "hls_fragments_per_ts_segment", hls_fragments_per_ts_segment)
        if manifest_name is not None:
            pulumi.set(__self__, "manifest_name", manifest_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if output_snap_time_in_seconds is not None:
            pulumi.set(__self__, "output_snap_time_in_seconds", output_snap_time_in_seconds)

    @property
    @pulumi.getter(name="archiveWindowDuration")
    def archive_window_duration(self) -> pulumi.Input[str]:
        """
        `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "archive_window_duration")

    @archive_window_duration.setter
    def archive_window_duration(self, value: pulumi.Input[str]):
        pulumi.set(self, "archive_window_duration", value)

    @property
    @pulumi.getter(name="assetName")
    def asset_name(self) -> pulumi.Input[str]:
        """
        The asset that the live output will write to. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "asset_name")

    @asset_name.setter
    def asset_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "asset_name", value)

    @property
    @pulumi.getter(name="liveEventId")
    def live_event_id(self) -> pulumi.Input[str]:
        """
        The id of the live event. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "live_event_id")

    @live_event_id.setter
    def live_event_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "live_event_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the live output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="hlsFragmentsPerTsSegment")
    def hls_fragments_per_ts_segment(self) -> Optional[pulumi.Input[int]]:
        """
        The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "hls_fragments_per_ts_segment")

    @hls_fragments_per_ts_segment.setter
    def hls_fragments_per_ts_segment(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "hls_fragments_per_ts_segment", value)

    @property
    @pulumi.getter(name="manifestName")
    def manifest_name(self) -> Optional[pulumi.Input[str]]:
        """
        The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "manifest_name")

    @manifest_name.setter
    def manifest_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "manifest_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="outputSnapTimeInSeconds")
    def output_snap_time_in_seconds(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "output_snap_time_in_seconds")

    @output_snap_time_in_seconds.setter
    def output_snap_time_in_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "output_snap_time_in_seconds", value)


@pulumi.input_type
class _LiveEventOutputState:
    def __init__(__self__, *,
                 archive_window_duration: Optional[pulumi.Input[str]] = None,
                 asset_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 hls_fragments_per_ts_segment: Optional[pulumi.Input[int]] = None,
                 live_event_id: Optional[pulumi.Input[str]] = None,
                 manifest_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 output_snap_time_in_seconds: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering LiveEventOutput resources.
        :param pulumi.Input[str] archive_window_duration: `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] asset_name: The asset that the live output will write to. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] description: The description of the live output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[int] hls_fragments_per_ts_segment: The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] live_event_id: The id of the live event. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] manifest_name: The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] name: The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        if archive_window_duration is not None:
            pulumi.set(__self__, "archive_window_duration", archive_window_duration)
        if asset_name is not None:
            pulumi.set(__self__, "asset_name", asset_name)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if hls_fragments_per_ts_segment is not None:
            pulumi.set(__self__, "hls_fragments_per_ts_segment", hls_fragments_per_ts_segment)
        if live_event_id is not None:
            pulumi.set(__self__, "live_event_id", live_event_id)
        if manifest_name is not None:
            pulumi.set(__self__, "manifest_name", manifest_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if output_snap_time_in_seconds is not None:
            pulumi.set(__self__, "output_snap_time_in_seconds", output_snap_time_in_seconds)

    @property
    @pulumi.getter(name="archiveWindowDuration")
    def archive_window_duration(self) -> Optional[pulumi.Input[str]]:
        """
        `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "archive_window_duration")

    @archive_window_duration.setter
    def archive_window_duration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "archive_window_duration", value)

    @property
    @pulumi.getter(name="assetName")
    def asset_name(self) -> Optional[pulumi.Input[str]]:
        """
        The asset that the live output will write to. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "asset_name")

    @asset_name.setter
    def asset_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "asset_name", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the live output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="hlsFragmentsPerTsSegment")
    def hls_fragments_per_ts_segment(self) -> Optional[pulumi.Input[int]]:
        """
        The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "hls_fragments_per_ts_segment")

    @hls_fragments_per_ts_segment.setter
    def hls_fragments_per_ts_segment(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "hls_fragments_per_ts_segment", value)

    @property
    @pulumi.getter(name="liveEventId")
    def live_event_id(self) -> Optional[pulumi.Input[str]]:
        """
        The id of the live event. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "live_event_id")

    @live_event_id.setter
    def live_event_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "live_event_id", value)

    @property
    @pulumi.getter(name="manifestName")
    def manifest_name(self) -> Optional[pulumi.Input[str]]:
        """
        The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "manifest_name")

    @manifest_name.setter
    def manifest_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "manifest_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="outputSnapTimeInSeconds")
    def output_snap_time_in_seconds(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "output_snap_time_in_seconds")

    @output_snap_time_in_seconds.setter
    def output_snap_time_in_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "output_snap_time_in_seconds", value)


class LiveEventOutput(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 archive_window_duration: Optional[pulumi.Input[str]] = None,
                 asset_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 hls_fragments_per_ts_segment: Optional[pulumi.Input[int]] = None,
                 live_event_id: Optional[pulumi.Input[str]] = None,
                 manifest_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 output_snap_time_in_seconds: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Manages a Azure Media Live Event Output.

        ## Import

        Live Outputs can be imported using the `resource id`, e.g.

        ```sh
         $ pulumi import azure:media/liveEventOutput:LiveEventOutput example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.Media/mediaservices/account1/liveevents/event1/liveoutputs/output1
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] archive_window_duration: `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] asset_name: The asset that the live output will write to. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] description: The description of the live output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[int] hls_fragments_per_ts_segment: The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] live_event_id: The id of the live event. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] manifest_name: The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] name: The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LiveEventOutputArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a Azure Media Live Event Output.

        ## Import

        Live Outputs can be imported using the `resource id`, e.g.

        ```sh
         $ pulumi import azure:media/liveEventOutput:LiveEventOutput example /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/group1/providers/Microsoft.Media/mediaservices/account1/liveevents/event1/liveoutputs/output1
        ```

        :param str resource_name: The name of the resource.
        :param LiveEventOutputArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LiveEventOutputArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 archive_window_duration: Optional[pulumi.Input[str]] = None,
                 asset_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 hls_fragments_per_ts_segment: Optional[pulumi.Input[int]] = None,
                 live_event_id: Optional[pulumi.Input[str]] = None,
                 manifest_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 output_snap_time_in_seconds: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LiveEventOutputArgs.__new__(LiveEventOutputArgs)

            if archive_window_duration is None and not opts.urn:
                raise TypeError("Missing required property 'archive_window_duration'")
            __props__.__dict__["archive_window_duration"] = archive_window_duration
            if asset_name is None and not opts.urn:
                raise TypeError("Missing required property 'asset_name'")
            __props__.__dict__["asset_name"] = asset_name
            __props__.__dict__["description"] = description
            __props__.__dict__["hls_fragments_per_ts_segment"] = hls_fragments_per_ts_segment
            if live_event_id is None and not opts.urn:
                raise TypeError("Missing required property 'live_event_id'")
            __props__.__dict__["live_event_id"] = live_event_id
            __props__.__dict__["manifest_name"] = manifest_name
            __props__.__dict__["name"] = name
            __props__.__dict__["output_snap_time_in_seconds"] = output_snap_time_in_seconds
        super(LiveEventOutput, __self__).__init__(
            'azure:media/liveEventOutput:LiveEventOutput',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            archive_window_duration: Optional[pulumi.Input[str]] = None,
            asset_name: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            hls_fragments_per_ts_segment: Optional[pulumi.Input[int]] = None,
            live_event_id: Optional[pulumi.Input[str]] = None,
            manifest_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            output_snap_time_in_seconds: Optional[pulumi.Input[int]] = None) -> 'LiveEventOutput':
        """
        Get an existing LiveEventOutput resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] archive_window_duration: `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] asset_name: The asset that the live output will write to. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] description: The description of the live output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[int] hls_fragments_per_ts_segment: The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] live_event_id: The id of the live event. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] manifest_name: The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        :param pulumi.Input[str] name: The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _LiveEventOutputState.__new__(_LiveEventOutputState)

        __props__.__dict__["archive_window_duration"] = archive_window_duration
        __props__.__dict__["asset_name"] = asset_name
        __props__.__dict__["description"] = description
        __props__.__dict__["hls_fragments_per_ts_segment"] = hls_fragments_per_ts_segment
        __props__.__dict__["live_event_id"] = live_event_id
        __props__.__dict__["manifest_name"] = manifest_name
        __props__.__dict__["name"] = name
        __props__.__dict__["output_snap_time_in_seconds"] = output_snap_time_in_seconds
        return LiveEventOutput(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="archiveWindowDuration")
    def archive_window_duration(self) -> pulumi.Output[str]:
        """
        `ISO 8601` time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use `PT1H30M` to indicate 1 hour and 30 minutes of archive window. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "archive_window_duration")

    @property
    @pulumi.getter(name="assetName")
    def asset_name(self) -> pulumi.Output[str]:
        """
        The asset that the live output will write to. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "asset_name")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the live output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="hlsFragmentsPerTsSegment")
    def hls_fragments_per_ts_segment(self) -> pulumi.Output[Optional[int]]:
        """
        The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "hls_fragments_per_ts_segment")

    @property
    @pulumi.getter(name="liveEventId")
    def live_event_id(self) -> pulumi.Output[str]:
        """
        The id of the live event. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "live_event_id")

    @property
    @pulumi.getter(name="manifestName")
    def manifest_name(self) -> pulumi.Output[str]:
        """
        The manifest file name. If not provided, the service will generate one automatically. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "manifest_name")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name which should be used for this Live Event Output. Changing this forces a new Live Output to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="outputSnapTimeInSeconds")
    def output_snap_time_in_seconds(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "output_snap_time_in_seconds")

