using My_First_ML_AppML.Model;
using System;

namespace My_First_ML_App
{
	class Program
	{
		static void Main(string[] args)
		{
			// Add input data
			var input = new ModelInput();
			//input.SentimentText = "That is rude"; // TOXIC : TRUE
			input.SentimentText = "I need some help"; // TOXIC : FALSE

			// Load model and predict output of sample data
			ModelOutput result = ConsumeModel.Predict(input);
			Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
		}
	}
}
