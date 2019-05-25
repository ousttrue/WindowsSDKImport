/// d3dcompiler.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D_BLOB_PART {
    D3D_BLOB_INPUT_SIGNATURE_BLOB = 0x00000000,
    D3D_BLOB_OUTPUT_SIGNATURE_BLOB = 0x00000001,
    D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB = 0x00000002,
    D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB = 0x00000003,
    D3D_BLOB_ALL_SIGNATURE_BLOB = 0x00000004,
    D3D_BLOB_DEBUG_INFO = 0x00000005,
    D3D_BLOB_LEGACY_SHADER = 0x00000006,
    D3D_BLOB_XNA_PREPASS_SHADER = 0x00000007,
    D3D_BLOB_XNA_SHADER = 0x00000008,
    D3D_BLOB_PDB = 0x00000009,
    D3D_BLOB_PRIVATE_DATA = 0x0000000a,
    D3D_BLOB_ROOT_SIGNATURE = 0x0000000b,
    D3D_BLOB_DEBUG_NAME = 0x0000000c,
    D3D_BLOB_TEST_ALTERNATE_SHADER = 0x00008000,
    D3D_BLOB_TEST_COMPILE_DETAILS = 0x00008001,
    D3D_BLOB_TEST_COMPILE_PERF = 0x00008002,
    D3D_BLOB_TEST_COMPILE_REPORT = 0x00008003,
}
}
