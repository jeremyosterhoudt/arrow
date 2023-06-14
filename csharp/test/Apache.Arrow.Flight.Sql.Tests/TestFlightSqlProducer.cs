using System.Reflection;
using Apache.Arrow.Flight.Protocol;
using Apache.Arrow.Flight.Server;
using Apache.Arrow.Types;
using Arrow.Flight.Protocol.Sql;
using Google.Protobuf;
using Grpc.Core;

namespace Apache.Arrow.Flight.Sql.Tests;

public class TestFlightSqlProducer : FlightSqlProducer
{
    protected override Task<FlightInfo> GetStatementQueryFlightInfo(CommandStatementQuery commandStatementQuery, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetPreparedStatementQueryFlightInfo(CommandPreparedStatementQuery preparedStatementQuery, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetCatalogFlightInfo(CommandGetCatalogs command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetDbSchemaFlightInfo(CommandGetDbSchemas command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetTablesFlightInfo(CommandGetTables command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetTableTypesFlightInfo(CommandGetTableTypes command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetSqlFlightInfo(CommandGetSqlInfo commandGetSqlInfo, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetPrimaryKeysFlightInfo(CommandGetPrimaryKeys command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetExportedKeysFlightInfo(CommandGetExportedKeys command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetImportedKeysFlightInfo(CommandGetImportedKeys command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetCrossReferenceFlightInfo(CommandGetCrossReference command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override Task<FlightInfo> GetXdbcTypeFlightInfo(CommandGetXdbcTypeInfo command, FlightDescriptor flightDescriptor, ServerCallContext serverCallContext) => Task.FromResult(new FlightInfo(null, FlightDescriptor.CreatePathDescriptor(MethodBase.GetCurrentMethod().Name), System.Array.Empty<FlightEndpoint>()));

    protected override async Task DoGetPreparedStatementQuery(CommandPreparedStatementQuery preparedStatementQuery, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetPreparedStatementQuery"));

    protected override async Task DoGetSqlInfo(CommandGetSqlInfo getSqlInfo, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetSqlInfo"));

    protected override async Task DoGetCatalog(CommandGetCatalogs command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetCatalog"));

    protected override async Task DoGetTableType(CommandGetTableTypes command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetTableType"));

    protected override async Task DoGetTables(CommandGetTables command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetTables"));

    protected override async Task DoGetPrimaryKeys(CommandGetPrimaryKeys command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetPrimaryKeys"));

    protected override async Task DoGetDbSchema(CommandGetDbSchemas command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetDbSchema"));

    protected override async Task DoGetExportedKeys(CommandGetExportedKeys command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetExportedKeys"));

    protected override async Task DoGetImportedKeys(CommandGetImportedKeys command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetImportedKeys"));

    protected override async Task DoGetCrossReference(CommandGetCrossReference command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetCrossReference"));

    protected override async Task DoGetXbdcTypeInfo(CommandGetXdbcTypeInfo command, FlightServerRecordBatchStreamWriter responseStream, ServerCallContext context) => await responseStream.WriteAsync(MockRecordBatch("DoGetXbdcTypeInfo"));

    protected override async Task CreatePreparedStatement(ActionCreatePreparedStatementRequest request, FlightAction action, IAsyncStreamWriter<FlightResult> streamWriter, ServerCallContext serverCallContext) => await streamWriter.WriteAsync(new FlightResult("CreatePreparedStatement"));

    protected override async Task ClosePreparedStatement(ActionClosePreparedStatementRequest request, FlightAction action, IAsyncStreamWriter<FlightResult> streamWriter, ServerCallContext serverCallContext) => await streamWriter.WriteAsync(new FlightResult("ClosePreparedStatement"));

    protected override async Task PutPreparedStatementUpdate(CommandPreparedStatementUpdate command, FlightServerRecordBatchStreamReader requestStream, IAsyncStreamWriter<FlightPutResult> responseStream, ServerCallContext context) => await responseStream.WriteAsync(new FlightPutResult("PutPreparedStatementUpdate"));

    protected override async Task PutStatementUpdate(CommandStatementUpdate command, FlightServerRecordBatchStreamReader requestStream, IAsyncStreamWriter<FlightPutResult> responseStream, ServerCallContext context) => await responseStream.WriteAsync(new FlightPutResult("PutStatementUpdate"));

    protected override async Task PutPreparedStatementQuery(CommandPreparedStatementQuery command, FlightServerRecordBatchStreamReader requestStream, IAsyncStreamWriter<FlightPutResult> responseStream, ServerCallContext context) => await responseStream.WriteAsync(new FlightPutResult("PutPreparedStatementQuery"));

    private RecordBatch MockRecordBatch(string name)
    {
        var schema = new Schema(new List<Field> {new(name, StringType.Default, false)}, System.Array.Empty<KeyValuePair<string, string>>());
        return new RecordBatch(schema, new []{ new StringArray.Builder().Append(name).Build() }, 1);
    }
}
