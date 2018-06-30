
namespace Utils.ExtensionMethods {

    static class ExtensionMethods {

        // A palavra reservada "this" na assinatura do método
        // é o que faz ele virar um Extension Method.
        public static string ToPlural(this string palavra) {
            return palavra.EndsWith("s") ? palavra : palavra + "s";
        }

    }

}
