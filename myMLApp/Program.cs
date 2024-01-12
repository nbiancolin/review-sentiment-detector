using MyMLApp;
// Add input data
Console.WriteLine("Enter your review: ");
string review = Console.ReadLine();
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = review
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");