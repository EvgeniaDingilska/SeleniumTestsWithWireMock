const puppeteer = require('puppeteer');

(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();

  // Replace 'https://example.com' with your desired URL
  await page.goto('http://localhost:3000');
  
  // Verify content on the page
  const pageTitle = await page.title();
  if (pageTitle.includes('W3.CSS Template')) {
    console.log('Content verification passed!');
  } else {
    console.error('Content verification failed.');
    process.exit(1); // Exit with a non-zero status code to indicate failure
  }

  // Close the browser
  await browser.close();
})();
