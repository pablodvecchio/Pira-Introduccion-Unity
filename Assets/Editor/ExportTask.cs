using System.IO;
using UnityEditor;
using UnityEngine;

public static class ExportTask
{
    private const string TargetAssetFolder = "Assets/Clase1";
    private const string OutputDirectoryName = "Tareas";
    private const string OutputFileName = "Clase1_Entrega.unitypackage";

    [MenuItem("Tools/Entregas/Exportar Clase 1")]
    public static void ExportTargetFolder()
    {
        if (!AssetDatabase.IsValidFolder(TargetAssetFolder))
        {
            Debug.LogError(
                $"[DeliveryExporter] Directorio objetivo no encontrado: {TargetAssetFolder}"
            );
            return;
        }

        string projectRoot = Directory.GetParent(Application.dataPath).FullName;
        string outputDirectoryPath = Path.Combine(projectRoot, OutputDirectoryName);
        string outputPath = Path.Combine(outputDirectoryPath, OutputFileName);

        try
        {
            if (!Directory.Exists(outputDirectoryPath))
            {
                Directory.CreateDirectory(outputDirectoryPath);
            }

            AssetDatabase.ExportPackage(
                TargetAssetFolder,
                outputPath,
                ExportPackageOptions.Recurse
            );

            Debug.Log($"[DeliveryExporter] Exportación exitosa: {outputPath}");

            if (
                EditorUtility.DisplayDialog(
                    "Éxito",
                    $"Entrega generada en:\n{outputPath}",
                    "Abrir Directorio",
                    "Cerrar"
                )
            )
            {
                EditorUtility.RevealInFinder(outputPath);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
            EditorUtility.DisplayDialog(
                "Error de I/O",
                $"Fallo en la exportación: {e.Message}",
                "Aceptar"
            );
        }
    }
}
